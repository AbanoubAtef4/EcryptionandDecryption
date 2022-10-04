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
using System.Xml.Serialization;

namespace RSA
{
    class RSA_Encryption
    {
        private static RSACryptoServiceProvider rsacsp = new RSACryptoServiceProvider(2048);

        private static RSAParameters publickey, privatekey;

        public RSA_Encryption()
        {
            publickey = rsacsp.ExportParameters(false);
            privatekey = rsacsp.ExportParameters(true);
        }

        public string getpublickey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, publickey);
            return sw.ToString();
        }
        public string getprivatekey()
        {
            var sw = new StringWriter();
            var xs = new XmlSerializer(typeof(RSAParameters));
            xs.Serialize(sw, privatekey);
            return sw.ToString();
        }

        public string encrypt(string plaintxet)
        {
            rsacsp = new RSACryptoServiceProvider();
            rsacsp.ImportParameters(publickey);
            var data = Encoding.Unicode.GetBytes(plaintxet);
            var cipher = rsacsp.Encrypt(data, false);
            var ciphertext = Convert.ToBase64String(cipher);
            return ciphertext;

        }


        public string decrypt(string ciphertxet)
        {
            var data = Convert.FromBase64String(ciphertxet);
            rsacsp.ImportParameters(privatekey);
            var plain = rsacsp.Decrypt(data, false);
            return Encoding.Unicode.GetString(plain);

        }
    }

   
}
