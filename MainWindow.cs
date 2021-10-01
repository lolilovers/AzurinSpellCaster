using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Security.Cryptography;
using System.IO;
using BCryptNet = BCrypt.Net.BCrypt;

namespace AzurinSpellCaster
{
    public partial class MainWindow : Form
    {
        private const int Keysize = 256;
        private const int DerivationIterations = 1000;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Close();
        }

        // Encode Button
        private void encoderBase64EncodeBtn_Click(object sender, EventArgs e)
        {
            String rawText  = encoderInputText.Text;
            String encodedText = Base64Encode(rawText);
            encoderOutputText.Text  = encodedText;
            statusLabel.Text = "Encode completed";
        }

        // Encoder
        public static string Base64Encode(string plainText)
        {
            var plainTextBytes = System.Text.Encoding.UTF8.GetBytes(plainText);
            return System.Convert.ToBase64String(plainTextBytes);
        }

        // Decoder
        public static string Base64Decode(string base64EncodedData)
        {
            try
            {
                var base64EncodedBytes = System.Convert.FromBase64String(base64EncodedData);
                return System.Text.Encoding.UTF8.GetString(base64EncodedBytes);
            }
            // When there is invalid input
            catch (Exception)
            {
                return "failed to decode data";
            }
        }

        // Decode button
        private void encoderBase64DecodeBtn_Click(object sender, EventArgs e)
        {
            String rawText = encoderInputText.Text;
            String decodedText = Base64Decode(rawText);
            encoderOutputText.Text = decodedText;
            statusLabel.Text = "Decode completed";
        }

        // Clear input and output text
        private void encoderClearBtn_Click(object sender, EventArgs e)
        {
            // clear text
            encoderInputText.Text = "";
            encoderOutputText.Text = "";
            // update status
            statusLabel.Text = "Encode/Decode data cleared";
        }

        // Encrypt/Decrypt Clear
        private void encryptClearBtn_Click(object sender, EventArgs e)
        {
            encrypterInputText.Text = "";
            encrypterOutputText.Text = "";
            statusLabel.Text = "Encrypt/Decrypt data clear completed";
        }

        // Encrypt button
        private void encryptBtn_Click(object sender, EventArgs e)
        {
            String cipher = encrypterInputText.Text;
            String salt = encrypterSaltText.Text;
            String encryptedData = Encrypt(cipher, salt);
            encrypterOutputText.Text = encryptedData;
            statusLabel.Text = "Encrypt completed";
        }

        // Decrypt button
        private void decryptBtn_Click(object sender, EventArgs e)
        {
            String encryptedText = encrypterInputText.Text;
            String salt = encrypterSaltText.Text;
            String decryptedText;
            try
            {
                decryptedText = Decrypt(encryptedText, salt);
            }
            catch
            {
                decryptedText = "Failed to decrypt data";
            }

            encrypterOutputText.Text = decryptedText;
            statusLabel.Text = "Decrypt completed";
        }

        public static string Decrypt(string cipherText, string passPhrase)
        {
            // Get the complete stream of bytes that represent:
            // [32 bytes of Salt] + [32 bytes of IV] + [n bytes of CipherText]
            var cipherTextBytesWithSaltAndIv = Convert.FromBase64String(cipherText);
            // Get the saltbytes by extracting the first 32 bytes from the supplied cipherText bytes.
            var saltStringBytes = cipherTextBytesWithSaltAndIv.Take(Keysize / 8).ToArray();
            // Get the IV bytes by extracting the next 32 bytes from the supplied cipherText bytes.
            var ivStringBytes = cipherTextBytesWithSaltAndIv.Skip(Keysize / 8).Take(Keysize / 8).ToArray();
            // Get the actual cipher text bytes by removing the first 64 bytes from the cipherText string.
            var cipherTextBytes = cipherTextBytesWithSaltAndIv.Skip((Keysize / 8) * 2).Take(cipherTextBytesWithSaltAndIv.Length - ((Keysize / 8) * 2)).ToArray();

            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var decryptor = symmetricKey.CreateDecryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream(cipherTextBytes))
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, decryptor, CryptoStreamMode.Read))
                            {
                                var plainTextBytes = new byte[cipherTextBytes.Length];
                                var decryptedByteCount = cryptoStream.Read(plainTextBytes, 0, plainTextBytes.Length);
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Encoding.UTF8.GetString(plainTextBytes, 0, decryptedByteCount);
                            }
                        }
                    }
                }
            }
        }

        public static string Encrypt(string plainText, string passPhrase)
        {
            // Salt and IV is randomly generated each time, but is preprended to encrypted cipher text
            // so that the same Salt and IV values can be used when decrypting.  
            var saltStringBytes = Generate256BitsOfRandomEntropy();
            var ivStringBytes = Generate256BitsOfRandomEntropy();
            var plainTextBytes = Encoding.UTF8.GetBytes(plainText);
            using (var password = new Rfc2898DeriveBytes(passPhrase, saltStringBytes, DerivationIterations))
            {
                var keyBytes = password.GetBytes(Keysize / 8);
                using (var symmetricKey = new RijndaelManaged())
                {
                    symmetricKey.BlockSize = 256;
                    symmetricKey.Mode = CipherMode.CBC;
                    symmetricKey.Padding = PaddingMode.PKCS7;
                    using (var encryptor = symmetricKey.CreateEncryptor(keyBytes, ivStringBytes))
                    {
                        using (var memoryStream = new MemoryStream())
                        {
                            using (var cryptoStream = new CryptoStream(memoryStream, encryptor, CryptoStreamMode.Write))
                            {
                                cryptoStream.Write(plainTextBytes, 0, plainTextBytes.Length);
                                cryptoStream.FlushFinalBlock();
                                // Create the final bytes as a concatenation of the random salt bytes, the random iv bytes and the cipher bytes.
                                var cipherTextBytes = saltStringBytes;
                                cipherTextBytes = cipherTextBytes.Concat(ivStringBytes).ToArray();
                                cipherTextBytes = cipherTextBytes.Concat(memoryStream.ToArray()).ToArray();
                                memoryStream.Close();
                                cryptoStream.Close();
                                return Convert.ToBase64String(cipherTextBytes);
                            }
                        }
                    }
                }
            }
        }

        private static byte[] Generate256BitsOfRandomEntropy()
        {
            var randomBytes = new byte[32]; // 32 Bytes will give us 256 bits.
            using (var rngCsp = new RNGCryptoServiceProvider())
            {
                // Fill the array with cryptographically secure random bytes.
                rngCsp.GetBytes(randomBytes);
            }
            return randomBytes;
        }

        // Randomizer clear button
        private void randomizerClearBtn_Click(object sender, EventArgs e)
        {
            randomizerOutputText.Text = "";
            statusLabel.Text = "Randomizer data cleared";
        }

        // Lorem ipsum button
        private void randomizerLoremBtn_Click(object sender, EventArgs e)
        {
            randomizerOutputText.Text = "Lorem ipsum dolor sit amet, consectetur adipisicing elit. Neque esse laudantium repellendus unde provident similique animi fugiat nostrum aspernatur mollitia tempora doloribus reiciendis numquam iure, molestias a adipisci? Magnam, esse?";
            statusLabel.Text = "Lorem ipsum created";
        }

        // MD5 Hash
        public static string CreateMD5(string input)
        {
            // Use input string to calculate MD5 hash
            using (MD5 md5 = MD5.Create())
            {
                byte[] inputBytes = System.Text.Encoding.ASCII.GetBytes(input);
                byte[] hashBytes = md5.ComputeHash(inputBytes);

                // Convert the byte array to hexadecimal string
                StringBuilder sb = new StringBuilder();
                for (int i = 0; i < hashBytes.Length; i++)
                {
                    sb.Append(hashBytes[i].ToString("X2"));
                }
                return sb.ToString();
            }
        }

        // MD5 button
        private void md5HashBtn_Click(object sender, EventArgs e)
        {
            String inputText = hashInputText.Text;
            String hashText = CreateMD5(inputText);
            hashOutputText.Text = hashText;
            statusLabel.Text = "MD5 Hash completed";
        }

        // Bcrypt button
        private void hashBcryptBtn_Click(object sender, EventArgs e)
        {
            String inputText = hashInputText.Text;
            String bcryptHash = BCrypt.Net.BCrypt.HashPassword(inputText);
            hashOutputText.Text = bcryptHash;
            statusLabel.Text = "bcrypt hash completed";
        }

        // MD5 verify button
        private void md5VerifyBtn_Click(object sender, EventArgs e)
        {
            String inputText = hashInputText.Text;
            String outputText = hashOutputText.Text;
            String hashText = CreateMD5(inputText);
            String outputVerify = outputText == hashText ? "Verify = true" : "Verify = false";
            MessageBox.Show(outputVerify, "md5 verify");
            statusLabel.Text = "MD5 verify hash completed";
        }

        // Bcrypt verify button
        private void bcryptVerifyBtn_Click(object sender, EventArgs e)
        {
            String inputText = hashInputText.Text;
            String outputText = hashOutputText.Text;
            bool verified;
            try
            {
                verified = BCrypt.Net.BCrypt.Verify(inputText, outputText);
            }
            catch
            {
                verified = false;
            }
            String outputVerify = verified ? "verify = true" : "verify = false";
            MessageBox.Show(outputVerify, "bcrypt verify");
            statusLabel.Text = "bcrypt verify hash completed";
        }

        // Hash clear button
        private void hashClearBtn_Click(object sender, EventArgs e)
        {
            hashInputText.Text = "";
            hashOutputText.Text = "";
            statusLabel.Text = "Hash data cleared";
        }

        // Random byte button
        private void randomByteBtn_Click(object sender, EventArgs e)
        {
            int minNumber = 0;
            int maxNumber = 0;
            String outputText;
            try
            {
                minNumber = int.Parse(randomizerMinText.Text);
                maxNumber = int.Parse(randomizerMaxText.Text);
            }
            catch
            {
                MessageBox.Show("invalid min/max number", "Random integer");
            }
            Random rnd = new Random();
            try
            {
                outputText = rnd.Next(minNumber, maxNumber).ToString();
            }
            catch
            {
                outputText = "failed to randomize integer";
            }
            randomizerOutputText.Text = outputText;
            statusLabel.Text = "Random integer created";
        }

        // Character randomizer
        public static char randomizeChar(string text)
        {
            string chars = text;
            Random rand = new Random();
            int num = rand.Next(0, chars.Length);
            return chars[num];
        }

        // Random String Button
        private void randomCharBtn_Click(object sender, EventArgs e)
        {
            String inputText = randomizerInputText.Text;
            String outputText;
            try
            {
                outputText = randomizeChar(inputText).ToString();
            }
            catch
            {
                outputText = "failed to random char";
            }
            randomizerOutputText.Text = outputText;
            statusLabel.Text = "Random char created";
        }

        // Random String
        public static string RandomString(string chars)
        {
            Random random = new Random();
            return new string(Enumerable.Repeat(chars, chars.Length)
              .Select(s => s[random.Next(s.Length)]).ToArray());
        }

        private void randomStringBtn_Click(object sender, EventArgs e)
        {
            String inputText = randomizerInputText.Text;
            String outputText;
            try
            {
                outputText = RandomString(inputText);
            }
            catch
            {
                outputText = "failed to randomize string";
            }
            randomizerOutputText.Text = outputText;
            statusLabel.Text = "Random string created";
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            new AboutWindow().Show();
        }
    }
}
