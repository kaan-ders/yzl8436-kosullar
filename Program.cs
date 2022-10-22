using System;

namespace yzl_8436_kosullar
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //oy verme yaşı kontrolü

            /*int yas = 0;

            Console.Write("Lütfen yaşınızı giriniz: ");
            yas = Convert.ToInt32(Console.ReadLine());

            if(yas >= 18)
            {
                Console.WriteLine("Oy verebilirsiniz");
                Console.WriteLine("Belki");
            }
            else
                Console.WriteLine("Oy veremezsiniz");

            Console.Read();*/

            //kargo hesaplama

            //string ulke, paraBirimi = "USD";
            //int kargoUcreti = 50;

            //Console.Write("Lütfen ülkenizi girin: ");
            //ulke = Console.ReadLine();

            //if(ulke == "Türkiye")
            //{
            //    kargoUcreti = 15;
            //    paraBirimi = "TL";
            //    //Console.WriteLine("Ödemeniz gereken kargo ücreti: " + 15 + " TL'dir");
            //}
            ///*else
            //{
            //    kargoUcreti = 50;
            //    paraBirimi = "USD";
            //    //Console.WriteLine("Ödemeniz gereken kargo ücreti: " + 50 + " USD'dir");
            //}*/

            //Console.WriteLine("Ödemeniz gereken kargo ücreti: " + kargoUcreti + " " + paraBirimi + "'dir");
            //Console.Read();


            //sayi1
            //sayi2
            //işlemi girin

            //hesap makinesi
            //-------------------------------------------------

            try
            {
                //int sayi1 = 0, sayi2 = 0;
                //string islem = "";

                //Console.Write("Lütfen ilk sayıyı giriniz: ");
                //sayi1 = Convert.ToInt32(Console.ReadLine());

                //if (sayi1 > 200)
                //    throw new ApplicationException("sayı 1 200'den büyük olamaz");

                //sayi1 = sayi1 / 0;

                //Console.Write("Lütfen ikinci sayıyı giriniz: ");
                //sayi2 = Convert.ToInt32(Console.ReadLine());

                //Console.Write("Lütfen işlemi giriniz: ");
                //islem = Console.ReadLine();

                //işlem kısmı

                //if (islem == "+" && (sayi1 >= 100 || sayi2 <= 200))
                //{
                //    Console.WriteLine("İşleminizin sonucu: " + (sayi1 + sayi2));
                //}
                //else
                //    Console.WriteLine("Değer hatalı");

                //if (islem == "-" || sayi1 < 200)
                //    Console.WriteLine("İşleminizin sonucu: " + (sayi1 - sayi2));

                //if (islem == "*")
                //    Console.WriteLine("İşleminizin sonucu: " + (sayi1 * sayi2));
                //else
                //    Console.WriteLine("İşleminizin sonucu: " + (sayi1 / sayi2));

                //if (islem == "+")
                //    Console.WriteLine("İşleminizin sonucu: " + (sayi1 + sayi2));
                //else if (islem == "-")
                //    Console.WriteLine("İşleminizin sonucu: " + (sayi1 - sayi2));
                //else if (islem == "*")
                //    Console.WriteLine("İşleminizin sonucu: " + (sayi1 * sayi2));
                //else
                //    Console.WriteLine("İşleminizin sonucu: " + (sayi1 / sayi2));

                //switch case

                //switch(islem)
                //{
                //    case "+":
                //        {
                //            Console.WriteLine("İşleminizin sonucu: " + (sayi1 + sayi2));
                //            break;
                //        }
                //    case "-":
                //        Console.WriteLine("İşleminizin sonucu: " + (sayi1 - sayi2));
                //        break;
                //    case "*":
                //        Console.WriteLine("İşleminizin sonucu: " + (sayi1 * sayi2));
                //        break;
                //    default:
                //        Console.WriteLine("İşleminizin sonucu: " + (sayi1 / sayi2));
                //        break;
                //}

                //mevsim kontrolü
                //---------------------

                //string mevsim;
                //mevsim = Console.ReadLine();

                //switch(mevsim)
                //{
                //    case "Kış":
                //        Console.WriteLine("Aralık-Ocak-Şubat");
                //        break;
                //    case "İlkbahar":
                //        Console.WriteLine("Mart-Nisan-Mayıs");
                //        break;
                //    case "Yaz":
                //        Console.WriteLine("Eylül-Ekim-Kasım");
                //        break;
                //    case "Sonbahar":
                //        Console.WriteLine("Haziran-Temmuz-Ağustos");
                //        break;
                //    default:
                //        Console.WriteLine("Yanlış mevsim girdiniz");
                //        break;
                //}

                //sayfa yönlendirme
                //------------------------

                //Eger kullanıcı "Admin","Moderator","Yonetici","CEO","Baskan" degerleri girilirse "Yönetim Paneline Yönlendiriliyorsunuz..."
                //"Uye" girilirse "Ana Sayfaya Yonlendiriliyorsunuz...";
                //Harici bir durumda "Bu Sayfayı Görme Yetkiniz Yok!";

                //string rol, mesaj;
                //Console.Write("Rol giriniz: ");
                //rol = Console.ReadLine();

                //switch (rol)
                //{
                //    case "admin":
                //    case "moderator":
                //    case "yonetici":
                //    case "ceo":
                //    case "baskan":
                //        mesaj = "Yönetim paneline yönelendiriliyorsunuz";
                //        break;
                //    case "uye":
                //        mesaj = "Ana sayfaya yönlendiriliyorsunuz";
                //        break;
                //    default:
                //        mesaj = "Yetkiniz yok";
                //        break;
                //}

                //Console.WriteLine(mesaj);

                //iç içe swicth case
                //------------------------------------

                //Kullanıcı adını ve şifresini kontrol ediniz.eğer kullanıcı kullanıcı adını ve şifresini doğru girerse "Tebrikler, hem kullanıcı adı hemde şifreniz doğru" uyarısı
                //Kullanıcı adı doğru şifre yanlışsa "Kullanıcı adınız doğru ancak şifreniz yanlış!" uyarısı
                //kullanıcı adı yanlışsa "Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!" uyarısını kullanıcıya veriniz.

                //KullaniciAdi = "bilgeadam";
                //Sifre = "1234";

                Console.Write("Kullanıcı adınızı giriniz: ");
                var kullaniciAdi = Console.ReadLine();

                Console.Write("Şifrenizi giriniz: ");
                string sifre = Console.ReadLine();

                //yol 1
                switch (kullaniciAdi)
                {
                    case "bilgeadam":
                        switch(sifre)
                        {
                            case "1234":
                                Console.WriteLine("Tebrikler, hem kullanıcı adı hem de şifreniz doğru!");
                                break;
                            default:
                                Console.WriteLine("Kullanıcı adınız doğru ancak şifreniz yanlış!");
                                break;
                        }
                        break;
                    default:
                        Console.WriteLine("Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!");
                        break;
                }

                //yol 2
                if(kullaniciAdi == "bilgeadam")
                {
                    if(sifre == "1234")
                        Console.WriteLine("Tebrikler, hem kullanıcı adı hem de şifreniz doğru!");
                    else
                        Console.WriteLine("Kullanıcı adınız doğru ancak şifreniz yanlış!");
                }
                else
                    Console.WriteLine("Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!");

                //yol 3
                if (kullaniciAdi == "bilgeadam" && sifre == "1234")
                    Console.WriteLine("Tebrikler, hem kullanıcı adı hem de şifreniz doğru!");
                else if (kullaniciAdi == "bilgeadam")
                    Console.WriteLine("Kullanıcı adınız doğru ancak şifreniz yanlış!");
                else
                    Console.WriteLine("Kullanıcı adınızı yanlış girdiniz, şifreye bakmadım bile!");
            }
            catch (Exception ex)
            {
                Console.WriteLine("Yanlış veri : " + ex.Message);
            }
            //finally
            //{

            //}

            Console.Read();
        }
    }
}

//Kış, İlkbahar, Sonbahar, Yaz

//Kış: "Aralık-Ocak-Şubat"
//İlkbahar: "Mart-Nisan-Mayıs"
//Sonbahar: "Eylül-Ekim-Kasım"
//Yaz: "Haziran-Temmuz-Ağustos"

/*
switch(islem)
{
    case "+":
        Console.WriteLine("İşleminizin sonucu: " + (sayi1 + sayi2));
        break;
    case "-":
        Console.WriteLine("İşleminizin sonucu: " + (sayi1 - sayi2));
        break;
    case "*":
        Console.WriteLine("İşleminizin sonucu: " + (sayi1 * sayi2));
        break;
    default:
        Console.WriteLine("İşleminizin sonucu: " + (sayi1 / sayi2));
        break;
}
*/

//