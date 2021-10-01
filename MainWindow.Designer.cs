
namespace AzurinSpellCaster
{
    partial class MainWindow
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabMain = new System.Windows.Forms.TabControl();
            this.tabEncodeDecode = new System.Windows.Forms.TabPage();
            this.encoderClearBtn = new System.Windows.Forms.Button();
            this.encoderBase64EncodeBtn = new System.Windows.Forms.Button();
            this.encoderBase64DecodeBtn = new System.Windows.Forms.Button();
            this.encoderInputLabel = new System.Windows.Forms.Label();
            this.encoderOutputLabel = new System.Windows.Forms.Label();
            this.encoderInputText = new System.Windows.Forms.RichTextBox();
            this.encoderOutputText = new System.Windows.Forms.RichTextBox();
            this.tabEncryptDecrypt = new System.Windows.Forms.TabPage();
            this.decryptBtn = new System.Windows.Forms.Button();
            this.encryptBtn = new System.Windows.Forms.Button();
            this.encryptSaltLabel = new System.Windows.Forms.Label();
            this.encryptClearBtn = new System.Windows.Forms.Button();
            this.encrypterInputText = new System.Windows.Forms.RichTextBox();
            this.encrypterSaltText = new System.Windows.Forms.TextBox();
            this.encryptOutputLabel = new System.Windows.Forms.Label();
            this.encrypterOutputText = new System.Windows.Forms.RichTextBox();
            this.encryptInputLabel = new System.Windows.Forms.Label();
            this.tabRandomizer = new System.Windows.Forms.TabPage();
            this.randomStringBtn = new System.Windows.Forms.Button();
            this.randomCharBtn = new System.Windows.Forms.Button();
            this.randomizerInputLabel = new System.Windows.Forms.Label();
            this.randomizerInputText = new System.Windows.Forms.RichTextBox();
            this.randomizerMaxText = new System.Windows.Forms.TextBox();
            this.randomizerMaxLabel = new System.Windows.Forms.Label();
            this.randomizerMinText = new System.Windows.Forms.TextBox();
            this.randomizerMinLabel = new System.Windows.Forms.Label();
            this.randomByteBtn = new System.Windows.Forms.Button();
            this.randomizerLoremBtn = new System.Windows.Forms.Button();
            this.randomizerClearBtn = new System.Windows.Forms.Button();
            this.randomizerOutputText = new System.Windows.Forms.RichTextBox();
            this.randomizerOutputLabel = new System.Windows.Forms.Label();
            this.tabHash = new System.Windows.Forms.TabPage();
            this.bcryptVerifyBtn = new System.Windows.Forms.Button();
            this.md5VerifyBtn = new System.Windows.Forms.Button();
            this.hashBcryptBtn = new System.Windows.Forms.Button();
            this.hashClearBtn = new System.Windows.Forms.Button();
            this.md5HashBtn = new System.Windows.Forms.Button();
            this.hashInputLabel = new System.Windows.Forms.Label();
            this.hashInputText = new System.Windows.Forms.RichTextBox();
            this.hashOutputLabel = new System.Windows.Forms.Label();
            this.hashOutputText = new System.Windows.Forms.RichTextBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.menuStrip1.SuspendLayout();
            this.tabMain.SuspendLayout();
            this.tabEncodeDecode.SuspendLayout();
            this.tabEncryptDecrypt.SuspendLayout();
            this.tabRandomizer.SuspendLayout();
            this.tabHash.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(687, 349);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 0;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(6, 349);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 1;
            this.button2.Text = "button2";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripMenuItem1,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(830, 28);
            this.menuStrip1.TabIndex = 2;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(46, 24);
            this.toolStripMenuItem1.Text = "File";
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(116, 26);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(55, 24);
            this.helpToolStripMenuItem.Text = "Help";
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(133, 26);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // tabMain
            // 
            this.tabMain.Controls.Add(this.tabEncodeDecode);
            this.tabMain.Controls.Add(this.tabEncryptDecrypt);
            this.tabMain.Controls.Add(this.tabRandomizer);
            this.tabMain.Controls.Add(this.tabHash);
            this.tabMain.Location = new System.Drawing.Point(0, 93);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(830, 331);
            this.tabMain.TabIndex = 3;
            // 
            // tabEncodeDecode
            // 
            this.tabEncodeDecode.Controls.Add(this.encoderClearBtn);
            this.tabEncodeDecode.Controls.Add(this.encoderBase64EncodeBtn);
            this.tabEncodeDecode.Controls.Add(this.encoderBase64DecodeBtn);
            this.tabEncodeDecode.Controls.Add(this.encoderInputLabel);
            this.tabEncodeDecode.Controls.Add(this.encoderOutputLabel);
            this.tabEncodeDecode.Controls.Add(this.encoderInputText);
            this.tabEncodeDecode.Controls.Add(this.encoderOutputText);
            this.tabEncodeDecode.Controls.Add(this.button2);
            this.tabEncodeDecode.Controls.Add(this.button1);
            this.tabEncodeDecode.Location = new System.Drawing.Point(4, 25);
            this.tabEncodeDecode.Name = "tabEncodeDecode";
            this.tabEncodeDecode.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncodeDecode.Size = new System.Drawing.Size(822, 302);
            this.tabEncodeDecode.TabIndex = 0;
            this.tabEncodeDecode.Text = "Encode/Decode";
            this.tabEncodeDecode.UseVisualStyleBackColor = true;
            // 
            // encoderClearBtn
            // 
            this.encoderClearBtn.Location = new System.Drawing.Point(739, 45);
            this.encoderClearBtn.Name = "encoderClearBtn";
            this.encoderClearBtn.Size = new System.Drawing.Size(75, 32);
            this.encoderClearBtn.TabIndex = 7;
            this.encoderClearBtn.Text = "Clear";
            this.encoderClearBtn.UseVisualStyleBackColor = true;
            this.encoderClearBtn.Click += new System.EventHandler(this.encoderClearBtn_Click);
            // 
            // encoderBase64EncodeBtn
            // 
            this.encoderBase64EncodeBtn.Location = new System.Drawing.Point(8, 16);
            this.encoderBase64EncodeBtn.Name = "encoderBase64EncodeBtn";
            this.encoderBase64EncodeBtn.Size = new System.Drawing.Size(125, 32);
            this.encoderBase64EncodeBtn.TabIndex = 7;
            this.encoderBase64EncodeBtn.Text = "Base64 Encode";
            this.encoderBase64EncodeBtn.UseVisualStyleBackColor = true;
            this.encoderBase64EncodeBtn.Click += new System.EventHandler(this.encoderBase64EncodeBtn_Click);
            // 
            // encoderBase64DecodeBtn
            // 
            this.encoderBase64DecodeBtn.Location = new System.Drawing.Point(144, 16);
            this.encoderBase64DecodeBtn.Name = "encoderBase64DecodeBtn";
            this.encoderBase64DecodeBtn.Size = new System.Drawing.Size(125, 32);
            this.encoderBase64DecodeBtn.TabIndex = 6;
            this.encoderBase64DecodeBtn.Text = "Base64 Decode";
            this.encoderBase64DecodeBtn.UseVisualStyleBackColor = true;
            this.encoderBase64DecodeBtn.Click += new System.EventHandler(this.encoderBase64DecodeBtn_Click);
            // 
            // encoderInputLabel
            // 
            this.encoderInputLabel.AutoSize = true;
            this.encoderInputLabel.Location = new System.Drawing.Point(8, 60);
            this.encoderInputLabel.Name = "encoderInputLabel";
            this.encoderInputLabel.Size = new System.Drawing.Size(39, 17);
            this.encoderInputLabel.TabIndex = 5;
            this.encoderInputLabel.Text = "Input";
            // 
            // encoderOutputLabel
            // 
            this.encoderOutputLabel.AutoSize = true;
            this.encoderOutputLabel.Location = new System.Drawing.Point(8, 180);
            this.encoderOutputLabel.Name = "encoderOutputLabel";
            this.encoderOutputLabel.Size = new System.Drawing.Size(51, 17);
            this.encoderOutputLabel.TabIndex = 4;
            this.encoderOutputLabel.Text = "Output";
            // 
            // encoderInputText
            // 
            this.encoderInputText.Location = new System.Drawing.Point(8, 83);
            this.encoderInputText.Name = "encoderInputText";
            this.encoderInputText.Size = new System.Drawing.Size(806, 96);
            this.encoderInputText.TabIndex = 3;
            this.encoderInputText.Text = "";
            // 
            // encoderOutputText
            // 
            this.encoderOutputText.Location = new System.Drawing.Point(8, 200);
            this.encoderOutputText.Name = "encoderOutputText";
            this.encoderOutputText.Size = new System.Drawing.Size(806, 96);
            this.encoderOutputText.TabIndex = 2;
            this.encoderOutputText.Text = "";
            // 
            // tabEncryptDecrypt
            // 
            this.tabEncryptDecrypt.Controls.Add(this.decryptBtn);
            this.tabEncryptDecrypt.Controls.Add(this.encryptBtn);
            this.tabEncryptDecrypt.Controls.Add(this.encryptSaltLabel);
            this.tabEncryptDecrypt.Controls.Add(this.encryptClearBtn);
            this.tabEncryptDecrypt.Controls.Add(this.encrypterInputText);
            this.tabEncryptDecrypt.Controls.Add(this.encrypterSaltText);
            this.tabEncryptDecrypt.Controls.Add(this.encryptOutputLabel);
            this.tabEncryptDecrypt.Controls.Add(this.encrypterOutputText);
            this.tabEncryptDecrypt.Controls.Add(this.encryptInputLabel);
            this.tabEncryptDecrypt.Location = new System.Drawing.Point(4, 25);
            this.tabEncryptDecrypt.Name = "tabEncryptDecrypt";
            this.tabEncryptDecrypt.Padding = new System.Windows.Forms.Padding(3);
            this.tabEncryptDecrypt.Size = new System.Drawing.Size(822, 302);
            this.tabEncryptDecrypt.TabIndex = 1;
            this.tabEncryptDecrypt.Text = "Encrypt/Decrypt";
            this.tabEncryptDecrypt.UseVisualStyleBackColor = true;
            // 
            // decryptBtn
            // 
            this.decryptBtn.Location = new System.Drawing.Point(624, 48);
            this.decryptBtn.Name = "decryptBtn";
            this.decryptBtn.Size = new System.Drawing.Size(96, 32);
            this.decryptBtn.TabIndex = 11;
            this.decryptBtn.Text = "Decrypt";
            this.decryptBtn.UseVisualStyleBackColor = true;
            this.decryptBtn.Click += new System.EventHandler(this.decryptBtn_Click);
            // 
            // encryptBtn
            // 
            this.encryptBtn.Location = new System.Drawing.Point(624, 8);
            this.encryptBtn.Name = "encryptBtn";
            this.encryptBtn.Size = new System.Drawing.Size(96, 32);
            this.encryptBtn.TabIndex = 10;
            this.encryptBtn.Text = "Encrypt";
            this.encryptBtn.UseVisualStyleBackColor = true;
            this.encryptBtn.Click += new System.EventHandler(this.encryptBtn_Click);
            // 
            // encryptSaltLabel
            // 
            this.encryptSaltLabel.AutoSize = true;
            this.encryptSaltLabel.Location = new System.Drawing.Point(8, 8);
            this.encryptSaltLabel.Name = "encryptSaltLabel";
            this.encryptSaltLabel.Size = new System.Drawing.Size(32, 17);
            this.encryptSaltLabel.TabIndex = 9;
            this.encryptSaltLabel.Text = "Salt";
            // 
            // encryptClearBtn
            // 
            this.encryptClearBtn.Location = new System.Drawing.Point(739, 45);
            this.encryptClearBtn.Name = "encryptClearBtn";
            this.encryptClearBtn.Size = new System.Drawing.Size(75, 32);
            this.encryptClearBtn.TabIndex = 7;
            this.encryptClearBtn.Text = "Clear";
            this.encryptClearBtn.UseVisualStyleBackColor = true;
            this.encryptClearBtn.Click += new System.EventHandler(this.encryptClearBtn_Click);
            // 
            // encrypterInputText
            // 
            this.encrypterInputText.Location = new System.Drawing.Point(8, 83);
            this.encrypterInputText.Name = "encrypterInputText";
            this.encrypterInputText.Size = new System.Drawing.Size(806, 96);
            this.encrypterInputText.TabIndex = 5;
            this.encrypterInputText.Text = "";
            // 
            // encrypterSaltText
            // 
            this.encrypterSaltText.Location = new System.Drawing.Point(8, 32);
            this.encrypterSaltText.Name = "encrypterSaltText";
            this.encrypterSaltText.Size = new System.Drawing.Size(600, 22);
            this.encrypterSaltText.TabIndex = 8;
            // 
            // encryptOutputLabel
            // 
            this.encryptOutputLabel.AutoSize = true;
            this.encryptOutputLabel.Location = new System.Drawing.Point(8, 180);
            this.encryptOutputLabel.Name = "encryptOutputLabel";
            this.encryptOutputLabel.Size = new System.Drawing.Size(51, 17);
            this.encryptOutputLabel.TabIndex = 4;
            this.encryptOutputLabel.Text = "Output";
            // 
            // encrypterOutputText
            // 
            this.encrypterOutputText.Location = new System.Drawing.Point(8, 200);
            this.encrypterOutputText.Name = "encrypterOutputText";
            this.encrypterOutputText.Size = new System.Drawing.Size(806, 96);
            this.encrypterOutputText.TabIndex = 3;
            this.encrypterOutputText.Text = "";
            // 
            // encryptInputLabel
            // 
            this.encryptInputLabel.AutoSize = true;
            this.encryptInputLabel.Location = new System.Drawing.Point(8, 60);
            this.encryptInputLabel.Name = "encryptInputLabel";
            this.encryptInputLabel.Size = new System.Drawing.Size(39, 17);
            this.encryptInputLabel.TabIndex = 2;
            this.encryptInputLabel.Text = "Input";
            // 
            // tabRandomizer
            // 
            this.tabRandomizer.Controls.Add(this.randomStringBtn);
            this.tabRandomizer.Controls.Add(this.randomCharBtn);
            this.tabRandomizer.Controls.Add(this.randomizerInputLabel);
            this.tabRandomizer.Controls.Add(this.randomizerInputText);
            this.tabRandomizer.Controls.Add(this.randomizerMaxText);
            this.tabRandomizer.Controls.Add(this.randomizerMaxLabel);
            this.tabRandomizer.Controls.Add(this.randomizerMinText);
            this.tabRandomizer.Controls.Add(this.randomizerMinLabel);
            this.tabRandomizer.Controls.Add(this.randomByteBtn);
            this.tabRandomizer.Controls.Add(this.randomizerLoremBtn);
            this.tabRandomizer.Controls.Add(this.randomizerClearBtn);
            this.tabRandomizer.Controls.Add(this.randomizerOutputText);
            this.tabRandomizer.Controls.Add(this.randomizerOutputLabel);
            this.tabRandomizer.Location = new System.Drawing.Point(4, 25);
            this.tabRandomizer.Name = "tabRandomizer";
            this.tabRandomizer.Padding = new System.Windows.Forms.Padding(3);
            this.tabRandomizer.Size = new System.Drawing.Size(822, 302);
            this.tabRandomizer.TabIndex = 2;
            this.tabRandomizer.Text = "Randomizer";
            this.tabRandomizer.UseVisualStyleBackColor = true;
            // 
            // randomStringBtn
            // 
            this.randomStringBtn.Location = new System.Drawing.Point(376, 8);
            this.randomStringBtn.Name = "randomStringBtn";
            this.randomStringBtn.Size = new System.Drawing.Size(128, 32);
            this.randomStringBtn.TabIndex = 13;
            this.randomStringBtn.Text = "Random String";
            this.randomStringBtn.UseVisualStyleBackColor = true;
            this.randomStringBtn.Click += new System.EventHandler(this.randomStringBtn_Click);
            // 
            // randomCharBtn
            // 
            this.randomCharBtn.Location = new System.Drawing.Point(240, 48);
            this.randomCharBtn.Name = "randomCharBtn";
            this.randomCharBtn.Size = new System.Drawing.Size(128, 32);
            this.randomCharBtn.TabIndex = 12;
            this.randomCharBtn.Text = "Random Char";
            this.randomCharBtn.UseVisualStyleBackColor = true;
            this.randomCharBtn.Click += new System.EventHandler(this.randomCharBtn_Click);
            // 
            // randomizerInputLabel
            // 
            this.randomizerInputLabel.AutoSize = true;
            this.randomizerInputLabel.Location = new System.Drawing.Point(8, 60);
            this.randomizerInputLabel.Name = "randomizerInputLabel";
            this.randomizerInputLabel.Size = new System.Drawing.Size(39, 17);
            this.randomizerInputLabel.TabIndex = 11;
            this.randomizerInputLabel.Text = "Input";
            // 
            // randomizerInputText
            // 
            this.randomizerInputText.Location = new System.Drawing.Point(8, 83);
            this.randomizerInputText.Name = "randomizerInputText";
            this.randomizerInputText.Size = new System.Drawing.Size(806, 96);
            this.randomizerInputText.TabIndex = 10;
            this.randomizerInputText.Text = "";
            // 
            // randomizerMaxText
            // 
            this.randomizerMaxText.Location = new System.Drawing.Point(120, 32);
            this.randomizerMaxText.Name = "randomizerMaxText";
            this.randomizerMaxText.Size = new System.Drawing.Size(100, 22);
            this.randomizerMaxText.TabIndex = 9;
            this.randomizerMaxText.UseWaitCursor = true;
            // 
            // randomizerMaxLabel
            // 
            this.randomizerMaxLabel.AutoSize = true;
            this.randomizerMaxLabel.Location = new System.Drawing.Point(120, 8);
            this.randomizerMaxLabel.Name = "randomizerMaxLabel";
            this.randomizerMaxLabel.Size = new System.Drawing.Size(33, 17);
            this.randomizerMaxLabel.TabIndex = 8;
            this.randomizerMaxLabel.Text = "Max";
            // 
            // randomizerMinText
            // 
            this.randomizerMinText.Location = new System.Drawing.Point(8, 32);
            this.randomizerMinText.Name = "randomizerMinText";
            this.randomizerMinText.Size = new System.Drawing.Size(100, 22);
            this.randomizerMinText.TabIndex = 7;
            // 
            // randomizerMinLabel
            // 
            this.randomizerMinLabel.AutoSize = true;
            this.randomizerMinLabel.Location = new System.Drawing.Point(8, 8);
            this.randomizerMinLabel.Name = "randomizerMinLabel";
            this.randomizerMinLabel.Size = new System.Drawing.Size(30, 17);
            this.randomizerMinLabel.TabIndex = 6;
            this.randomizerMinLabel.Text = "Min";
            // 
            // randomByteBtn
            // 
            this.randomByteBtn.Location = new System.Drawing.Point(240, 8);
            this.randomByteBtn.Name = "randomByteBtn";
            this.randomByteBtn.Size = new System.Drawing.Size(128, 32);
            this.randomByteBtn.TabIndex = 5;
            this.randomByteBtn.Text = "Random Integer";
            this.randomByteBtn.UseVisualStyleBackColor = true;
            this.randomByteBtn.Click += new System.EventHandler(this.randomByteBtn_Click);
            // 
            // randomizerLoremBtn
            // 
            this.randomizerLoremBtn.Location = new System.Drawing.Point(376, 48);
            this.randomizerLoremBtn.Name = "randomizerLoremBtn";
            this.randomizerLoremBtn.Size = new System.Drawing.Size(128, 32);
            this.randomizerLoremBtn.TabIndex = 4;
            this.randomizerLoremBtn.Text = "lorem ipsum";
            this.randomizerLoremBtn.UseVisualStyleBackColor = true;
            this.randomizerLoremBtn.Click += new System.EventHandler(this.randomizerLoremBtn_Click);
            // 
            // randomizerClearBtn
            // 
            this.randomizerClearBtn.Location = new System.Drawing.Point(739, 45);
            this.randomizerClearBtn.Name = "randomizerClearBtn";
            this.randomizerClearBtn.Size = new System.Drawing.Size(75, 32);
            this.randomizerClearBtn.TabIndex = 3;
            this.randomizerClearBtn.Text = "Clear";
            this.randomizerClearBtn.UseVisualStyleBackColor = true;
            this.randomizerClearBtn.Click += new System.EventHandler(this.randomizerClearBtn_Click);
            // 
            // randomizerOutputText
            // 
            this.randomizerOutputText.Location = new System.Drawing.Point(8, 200);
            this.randomizerOutputText.Name = "randomizerOutputText";
            this.randomizerOutputText.Size = new System.Drawing.Size(806, 96);
            this.randomizerOutputText.TabIndex = 2;
            this.randomizerOutputText.Text = "";
            // 
            // randomizerOutputLabel
            // 
            this.randomizerOutputLabel.AutoSize = true;
            this.randomizerOutputLabel.Location = new System.Drawing.Point(8, 180);
            this.randomizerOutputLabel.Name = "randomizerOutputLabel";
            this.randomizerOutputLabel.Size = new System.Drawing.Size(51, 17);
            this.randomizerOutputLabel.TabIndex = 1;
            this.randomizerOutputLabel.Text = "Output";
            // 
            // tabHash
            // 
            this.tabHash.Controls.Add(this.bcryptVerifyBtn);
            this.tabHash.Controls.Add(this.md5VerifyBtn);
            this.tabHash.Controls.Add(this.hashBcryptBtn);
            this.tabHash.Controls.Add(this.hashClearBtn);
            this.tabHash.Controls.Add(this.md5HashBtn);
            this.tabHash.Controls.Add(this.hashInputLabel);
            this.tabHash.Controls.Add(this.hashInputText);
            this.tabHash.Controls.Add(this.hashOutputLabel);
            this.tabHash.Controls.Add(this.hashOutputText);
            this.tabHash.Location = new System.Drawing.Point(4, 25);
            this.tabHash.Name = "tabHash";
            this.tabHash.Padding = new System.Windows.Forms.Padding(3);
            this.tabHash.Size = new System.Drawing.Size(822, 302);
            this.tabHash.TabIndex = 3;
            this.tabHash.Text = "Hash";
            this.tabHash.UseVisualStyleBackColor = true;
            // 
            // bcryptVerifyBtn
            // 
            this.bcryptVerifyBtn.Location = new System.Drawing.Point(328, 16);
            this.bcryptVerifyBtn.Name = "bcryptVerifyBtn";
            this.bcryptVerifyBtn.Size = new System.Drawing.Size(104, 32);
            this.bcryptVerifyBtn.TabIndex = 8;
            this.bcryptVerifyBtn.Text = "BCrypt Verify";
            this.bcryptVerifyBtn.UseVisualStyleBackColor = true;
            this.bcryptVerifyBtn.Click += new System.EventHandler(this.bcryptVerifyBtn_Click);
            // 
            // md5VerifyBtn
            // 
            this.md5VerifyBtn.Location = new System.Drawing.Point(112, 16);
            this.md5VerifyBtn.Name = "md5VerifyBtn";
            this.md5VerifyBtn.Size = new System.Drawing.Size(96, 32);
            this.md5VerifyBtn.TabIndex = 7;
            this.md5VerifyBtn.Text = "MD5 Verify";
            this.md5VerifyBtn.UseVisualStyleBackColor = true;
            this.md5VerifyBtn.Click += new System.EventHandler(this.md5VerifyBtn_Click);
            // 
            // hashBcryptBtn
            // 
            this.hashBcryptBtn.Location = new System.Drawing.Point(216, 16);
            this.hashBcryptBtn.Name = "hashBcryptBtn";
            this.hashBcryptBtn.Size = new System.Drawing.Size(104, 32);
            this.hashBcryptBtn.TabIndex = 6;
            this.hashBcryptBtn.Text = "BCrypt Hash";
            this.hashBcryptBtn.UseVisualStyleBackColor = true;
            this.hashBcryptBtn.Click += new System.EventHandler(this.hashBcryptBtn_Click);
            // 
            // hashClearBtn
            // 
            this.hashClearBtn.Location = new System.Drawing.Point(739, 45);
            this.hashClearBtn.Name = "hashClearBtn";
            this.hashClearBtn.Size = new System.Drawing.Size(75, 32);
            this.hashClearBtn.TabIndex = 5;
            this.hashClearBtn.Text = "Clear";
            this.hashClearBtn.UseVisualStyleBackColor = true;
            this.hashClearBtn.Click += new System.EventHandler(this.hashClearBtn_Click);
            // 
            // md5HashBtn
            // 
            this.md5HashBtn.Location = new System.Drawing.Point(8, 16);
            this.md5HashBtn.Name = "md5HashBtn";
            this.md5HashBtn.Size = new System.Drawing.Size(96, 32);
            this.md5HashBtn.TabIndex = 4;
            this.md5HashBtn.Text = "MD5 Hash";
            this.md5HashBtn.UseVisualStyleBackColor = true;
            this.md5HashBtn.Click += new System.EventHandler(this.md5HashBtn_Click);
            // 
            // hashInputLabel
            // 
            this.hashInputLabel.AutoSize = true;
            this.hashInputLabel.Location = new System.Drawing.Point(8, 60);
            this.hashInputLabel.Name = "hashInputLabel";
            this.hashInputLabel.Size = new System.Drawing.Size(39, 17);
            this.hashInputLabel.TabIndex = 3;
            this.hashInputLabel.Text = "Input";
            // 
            // hashInputText
            // 
            this.hashInputText.Location = new System.Drawing.Point(8, 83);
            this.hashInputText.Name = "hashInputText";
            this.hashInputText.Size = new System.Drawing.Size(806, 96);
            this.hashInputText.TabIndex = 2;
            this.hashInputText.Text = "";
            // 
            // hashOutputLabel
            // 
            this.hashOutputLabel.AutoSize = true;
            this.hashOutputLabel.Location = new System.Drawing.Point(8, 180);
            this.hashOutputLabel.Name = "hashOutputLabel";
            this.hashOutputLabel.Size = new System.Drawing.Size(51, 17);
            this.hashOutputLabel.TabIndex = 1;
            this.hashOutputLabel.Text = "Output";
            // 
            // hashOutputText
            // 
            this.hashOutputText.Location = new System.Drawing.Point(8, 200);
            this.hashOutputText.Name = "hashOutputText";
            this.hashOutputText.Size = new System.Drawing.Size(806, 96);
            this.hashOutputText.TabIndex = 0;
            this.hashOutputText.Text = "";
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.Location = new System.Drawing.Point(12, 427);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(49, 17);
            this.statusLabel.TabIndex = 6;
            this.statusLabel.Text = "Ready";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Location = new System.Drawing.Point(-8, 32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(848, 55);
            this.pictureBox1.TabIndex = 7;
            this.pictureBox1.TabStop = false;
            // 
            // MainWindow
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 453);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.statusLabel);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.Name = "MainWindow";
            this.Text = "Spell Caster - Azurin";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabMain.ResumeLayout(false);
            this.tabEncodeDecode.ResumeLayout(false);
            this.tabEncodeDecode.PerformLayout();
            this.tabEncryptDecrypt.ResumeLayout(false);
            this.tabEncryptDecrypt.PerformLayout();
            this.tabRandomizer.ResumeLayout(false);
            this.tabRandomizer.PerformLayout();
            this.tabHash.ResumeLayout(false);
            this.tabHash.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.TabControl tabMain;
        private System.Windows.Forms.TabPage tabEncodeDecode;
        private System.Windows.Forms.TabPage tabEncryptDecrypt;
        private System.Windows.Forms.TabPage tabRandomizer;
        private System.Windows.Forms.Label randomizerOutputLabel;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Label encoderInputLabel;
        private System.Windows.Forms.Label encoderOutputLabel;
        private System.Windows.Forms.RichTextBox encoderInputText;
        private System.Windows.Forms.RichTextBox encoderOutputText;
        private System.Windows.Forms.Button encoderBase64EncodeBtn;
        private System.Windows.Forms.Button encoderBase64DecodeBtn;
        private System.Windows.Forms.Button encoderClearBtn;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.TabPage tabHash;
        private System.Windows.Forms.Label encryptSaltLabel;
        private System.Windows.Forms.TextBox encrypterSaltText;
        private System.Windows.Forms.Button encryptClearBtn;
        private System.Windows.Forms.RichTextBox encrypterInputText;
        private System.Windows.Forms.Label encryptOutputLabel;
        private System.Windows.Forms.RichTextBox encrypterOutputText;
        private System.Windows.Forms.Label encryptInputLabel;
        private System.Windows.Forms.Button randomizerClearBtn;
        private System.Windows.Forms.RichTextBox randomizerOutputText;
        private System.Windows.Forms.Button hashClearBtn;
        private System.Windows.Forms.Button md5HashBtn;
        private System.Windows.Forms.Label hashInputLabel;
        private System.Windows.Forms.RichTextBox hashInputText;
        private System.Windows.Forms.Label hashOutputLabel;
        private System.Windows.Forms.RichTextBox hashOutputText;
        private System.Windows.Forms.Button encryptBtn;
        private System.Windows.Forms.Button decryptBtn;
        private System.Windows.Forms.Button randomizerLoremBtn;
        private System.Windows.Forms.Button hashBcryptBtn;
        private System.Windows.Forms.Button bcryptVerifyBtn;
        private System.Windows.Forms.Button md5VerifyBtn;
        private System.Windows.Forms.Button randomByteBtn;
        private System.Windows.Forms.TextBox randomizerMaxText;
        private System.Windows.Forms.Label randomizerMaxLabel;
        private System.Windows.Forms.TextBox randomizerMinText;
        private System.Windows.Forms.Label randomizerMinLabel;
        private System.Windows.Forms.Label randomizerInputLabel;
        private System.Windows.Forms.RichTextBox randomizerInputText;
        private System.Windows.Forms.Button randomCharBtn;
        private System.Windows.Forms.Button randomStringBtn;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

