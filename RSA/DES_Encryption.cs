using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Security.Cryptography;
using System.IO;
using System.Xml.Serialization;

namespace RSA
{
    class DES_Encryption
    {
        public string DESEncryption(string plain, string key)
        {
            string cipher;
            if (plain != "")
            {

                if (key != "")
                {
                    bool check = false;
                    for (int i = 0; i < key.Length; i++)
                    {
                        if (key[i] >= '0' && key[i] <= '9')
                        {
                            check = true;

                        }
                    }
                    if (check && key.Length == 8)
                    {


                        byte[] publickey= { };
                        byte[] privatekey = { 0x01, 0x03, 0x09, 0x04, 0x06, 0x02, 0x08, 0x05  };
                        publickey = Encoding.UTF8.GetBytes(key);
                        DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                        byte[] text = Encoding.UTF8.GetBytes(plain);
                        MemoryStream m = new MemoryStream();
                        CryptoStream c = new CryptoStream(m, des.CreateEncryptor(publickey, privatekey), CryptoStreamMode.Write);
                        c.Write(text, 0, text.Length);
                        c.FlushFinalBlock();
                        cipher = Convert.ToBase64String(m.ToArray());

                        return cipher;
                    }
                    else
                    {
                        cipher = " Please Enter 8 numbers for the Key ^_^ .";
                        return cipher;
                    }

                }
                else
                {
                    cipher = "Please Enter The Key Frist ^_^ .";
                    return cipher;
                }

            }
            else
            {
                cipher = "Please Enter The PlainText Frist ^_^ .";
                return cipher;
            }
        }

        public string DESDecryption(string cipher, string key)
        {
            string plain = "";
            if (cipher != "")
            {

                if (key != "")
                {
                    bool check = false;
                    for (int i = 0; i < key.Length; i++)
                    {
                        if (key[i] >= '0' && key[i] <= '9')
                        {
                            check = true;

                        }
                    }
                    if (check && key.Length == 8)
                    {
                        byte[] publickey = { };
                        byte[] privatekey = { 0x01, 0x03, 0x09, 0x04, 0x06, 0x02, 0x08, 0x05 };

                        publickey = Encoding.UTF8.GetBytes(key);
                        DESCryptoServiceProvider des = new DESCryptoServiceProvider();
                        byte[] text = new byte[cipher.Length];
                        text = Convert.FromBase64String(cipher);
                        MemoryStream m = new MemoryStream();
                        CryptoStream c = new CryptoStream(m, des.CreateDecryptor(publickey, privatekey), CryptoStreamMode.Write);
                        c.Write(text, 0, text.Length);
                        c.FlushFinalBlock();
                        Encoding txt = Encoding.UTF8;

                        return txt.GetString(m.ToArray());

                    }
                    else
                    {
                        cipher = " Please Enter 8 numbers for the Key ^_^ .";
                        return cipher;
                    }
                }
                else
                {
                    plain = "Please Enter The Key Frist ^_^ .";
                    return plain;
                }

            }
            else
            {
                plain = "Please Enter The CipherText Frist ^_^ .";
                return plain;
            }
        }
    }
}
