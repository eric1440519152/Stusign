﻿using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Web;

namespace Stusign.Libraries
{
    public class SafeCrypto
    {
        public static string EncodeBase64(string code,string code_type = "utf-8")
        {
            string encode = "";
            byte[] bytes = Encoding.GetEncoding(code_type).GetBytes(code);
            try
            {
                encode = Convert.ToBase64String(bytes);
            }
            catch
            {
                encode = code;
            }
            return encode;
        }

        ///解码
        public static string DecodeBase64(string code,string code_type = "utf-8")
        {
            string decode = "";
            byte[] bytes = Convert.FromBase64String(code);
            try
            {
                decode = Encoding.GetEncoding(code_type).GetString(bytes);
            }
            catch
            {
                decode = code;
            }
            return decode;
        }

        public static byte[] hash_hmac(string signatureString, string secretKey)
        {
            var enc = Encoding.UTF8;
            HMACSHA1 hmac = new HMACSHA1(enc.GetBytes(secretKey));
            hmac.Initialize();

            byte[] buffer = enc.GetBytes(signatureString);
            return hmac.ComputeHash(buffer);
        }

        public static string signHash(string signatureString, string secretKey = "Stusign")
        {
            var enc = Encoding.UTF8;
            var md5 = System.Security.Cryptography.MD5.Create();

            var buffer = enc.GetBytes(signatureString+secretKey);
            buffer = md5.ComputeHash(buffer);
            return Convert.ToBase64String(buffer);
        }
        public static string MD5(string text, string charset)
        {
            try
            {
                MD5CryptoServiceProvider MD5 = new MD5CryptoServiceProvider();
                return BitConverter
                    .ToString(MD5
                        .ComputeHash(Encoding
                            .GetEncoding(charset)
                            .GetBytes(text)))
                    .Replace("-", "");
            }
            catch
            {
            }

            return string.Empty;
        }
    }
}
