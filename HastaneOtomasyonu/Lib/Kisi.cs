﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace HastaneOtomasyonu
{
    public abstract class Kisi
    {
        private string _ad, _soyad, _telefon, _email, _tckn;

        public string Ad
        {
            get => this._ad;

            set
            {
                NameValid(value, "Ad");
                value = value.Trim();
                this._ad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Soyad
        {
            get => this._soyad;
            set
            {
                NameValid(value, "Soyad");
                value = value.Trim();
                this._soyad = value.Substring(0, 1).ToUpper() + value.Substring(1).ToLower();
            }
        }

        public string Telefon
        {
            get => this._telefon;
            set
            {
                if (!value.StartsWith("0"))
                    throw new Exception("Telefon numarasi 0 ile baslamali");
                if (value.Length != 11)
                    throw new Exception("Telefon numaraniz 11 hane olmali");
                foreach (char digit in value)
                {
                    if (!char.IsDigit(digit))
                        throw new Exception("Telefon numaraniz sadece rakamlardan olusmalidir");
                }

                this._telefon = value;
            }
        }

        public string email
        {
            get => this._email;

            set
            {
                Regex rgx = new Regex(@"^[\w-\.]+@([\w-]+\.)+[\w-]{2,4}$");
                if (!rgx.IsMatch(value))
                    throw new Exception("Lutfen bir email adresi giriniz");
                this._email = value;
            }
        }

        public string TCKN
        {
            get => this._tckn;
            set
            {
                if (value.Length != 11)
                    throw new Exception("TCKN 11 haneli olmalidir");
                foreach (char harf in value)
                {
                    if (!char.IsDigit(harf))
                        throw new Exception("TCKN sadece rakamlardan olusmalidir");
                }

                this._tckn = value;
            }
        }

        public Kisi() { }

        public Kisi(string ad, string soyad)
        {
            this._ad = ad;
            this._soyad = soyad;
        }

        private void NameValid(string value, string propertyName)
        {
            foreach (char harf in propertyName)
            {
                if (!(char.IsLetter(harf) || char.IsWhiteSpace(harf)))
                {
                    throw new Exception($"{propertyName} girisi sadece harf ve bosluklarla yapilmalidir.");
                }
            }
        }

        public override string ToString()
        {
            return $"{Ad} {Soyad}";
        }
    }
}
