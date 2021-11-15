using System;
using System.Collections.Generic;
using System.Text;

namespace uygula1
{
    class Bilgi
    {
        private List<string> kelimeler;
        private Dictionary<char, int> harfFrekans;
        public Bilgi()
        {
            kelimeler = new List<string>();
            harfFrekans = new Dictionary<char, int>();
        }
        public void KelimeCikar(string Text)
        {
            string[] parcalar = Text.Split(' ');//metni boşluklara böl
            foreach(string parca in parcalar) //parcalar dizisindeki her eleman icin
            {
                //her elemanı listede yoksa ekle
                if (!kelimeler.Contains(parca)) //eger parca listede yoksa
                {
                    kelimeler.Add(parca); //listeye ekle
                }
            }           
        }
        public List<string> KelimeAl()
        {
            return kelimeler;
        }
        public void HarfCikar(string Text)
        {
            for (int i = 0; i < Text.Length; i++) //metni döngüyle gez
            {
                char karakter = Text[i];
                if (harfFrekans.ContainsKey(karakter)) //karakter sozlukte varsa
                {
                    harfFrekans[karakter]++; //harfFrekans[karakter]=harfFrekans[karakter]+1
                }
                else //yoksa
                {
                    harfFrekans.Add(karakter, 1); //bir defa gecmis oldugu icin 1 frekansı ile sozluge ekle 
                }
            }
        }
        public List<string> HarfAl()
        {
            List<string> sonuclar = new List<string>();
            foreach (KeyValuePair<char,int> eleman in harfFrekans) //sözlüğün tüm elemanları için
            {
                string satir = $"'{eleman.Key}' - {eleman.Value}"; //sözlüğün sıradaki elemanını "-" karakteri ile birleştir
                sonuclar.Add(satir); //listeye ekle
            }
            return sonuclar; //listeyi dondur
        }
        public List<string> KelimeAra(string Aranan)
        {
            List<string> sonucListesi = new List<string>();
            foreach(var siradaki in kelimeler) //listenin her elemani icin
            {
                if (siradaki.Contains(Aranan)) //eger siradaki kelimem aranan metni iceriyorsa
                {
                    sonucListesi.Add(siradaki); //bulunanları bir listeyi ekle
                } 
            }
            return sonucListesi;//ve listeyi döndür             
        }
        public string HarfAra(char aranan)
        {
            if (harfFrekans.ContainsKey(aranan))
                return $"'{aranan}' - {harfFrekans[aranan]}"; //aranan harfi sözlükten döndür
            else
                return "Bulunamadi";
        }
    }

}
