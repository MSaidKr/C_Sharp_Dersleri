using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace ders_0_kitaptan_ilerlemeler
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region uygulama 8 (takım örneği)

            //Console.WriteLine("tuttuğunuz takımın baş harfini giriniz?");
            //string takım;
            //takım = Console.ReadLine();
            //if (takım == "g")
            //{
            //    Console.WriteLine("galatasaray");
            //}
            //if (takım == "b")
            //{
            //    Console.WriteLine("beşiktaş");
            //}
            //if (takım == "f")
            //{
            //    Console.WriteLine("fenerbahçe");
            //}
            //if (takım == "t")
            //{
            //    Console.WriteLine("trabzon spor");
            //}
            //if (takım == "r")
            //{
            //    Console.WriteLine("rize spor");
            //}
            //if (takım == "s")
            //{
            //    Console.WriteLine("sivas spor");
            //}
            #endregion

            #region uygulama 9 (bölünme sorusu)

            //Console.WriteLine("6'ya bölünen bir sayı giriniz.");
            //int sayi = int.Parse(Console.ReadLine());
            //if (sayi % 2 == 0 & sayi % 3 == 0)
            //{
            //    Console.WriteLine("sayı 6'nın bir katı");
            //}
            //else
            //{
            //    Console.WriteLine("sayı 6'nın bir katı değil");
            //}
            #endregion

            #region uygulama 10 (5 meyve çevirme örneği)

            //Console.WriteLine("1-portakal ");
            //Console.WriteLine("2-elma");
            //Console.WriteLine("3-muz");
            //Console.WriteLine("4-şeftali");
            //Console.WriteLine("5-ananas");
            //Console.WriteLine("Çevirmek istediğiniz kelimeyi seçiniz");
            //Console.WriteLine("-------------------------------------");
            //int seçim = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------------");
            //    switch (seçim)
            //{
            //    case 1: Console.WriteLine("orange"); break;
            //    case 2: Console.WriteLine("apple"); break;
            //    case 3: Console.WriteLine("banana"); break;
            //    case 4: Console.WriteLine("peach"); break;
            //    case 5: Console.WriteLine("pineapple"); break;
            //}
            #endregion

            #region rastgele uygulamalar 1 (lotr karakterleri)

            //Console.WriteLine("Adını görmek istediğiniz ırkın numarasını girin.");
            //Console.WriteLine("-------------------------------------------------");
            //Console.WriteLine("1-elf");
            //Console.WriteLine("2-org");
            //Console.WriteLine("3-insan");
            //Console.WriteLine("4-büyücü");
            //Console.WriteLine("5-cüce");
            //Console.WriteLine();
            //int seçim = int.Parse(Console.ReadLine());
            //Console.WriteLine("-------------------------------------------------");
            //switch(seçim)
            //{
            //    case 1: Console.WriteLine("legolas"); break;
            //    case 2: Console.WriteLine("götoş"); break;
            //    case 3: Console.WriteLine("aragorn");break;
            //    case 4: Console.WriteLine("gandalf the gray");break;
            //    case 5: Console.WriteLine("gimli");break;
            //}

            #endregion

            #region rastgele uygulamalar (dizi uygulamaları)

            //string[] şehirler = new string[5];
            //şehirler[0] = "rize";
            //şehirler[1] = "eskişehir";
            //şehirler[2] = "bolu";
            //şehirler[3] = "artvin";
            //şehirler[4] = "samsun";
            //Console.WriteLine("1-rize\n2-eskişehir\n3-bolu\n4-artvin\n5-samsun");
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine("görmek istediğiniz şehrin sırasını girin.");
            //Console.WriteLine();
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("----------------------------------");
            //Console.WriteLine(şehirler[a-1]);

            //string[] samuraylar = { "kappa", "kinemon", "ashura", "ken" };
            //for (int i = 0; i < samuraylar.Length; i++)
            //{
            //    Console.WriteLine(samuraylar[i]);
            //}

            //string[] şehirler = { "rize", "eskişehir", "trabzon", "istanbul", "artvin", "ankara", "adana" };
            //Console.WriteLine("1-rize\n2-eskişehir\n3-trabzon\n4-istanbul\n5-artvin\n6-ankara\n7-adana");
            //Console.WriteLine("plakasını görmek istediğiniz şehrin numarasını girin");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine("------------------");
            //string[] plakalar = { "53", "26", "61", "32", "08", "06", "01" };
            //Console.WriteLine(şehirler[x-1] + " " + plakalar[x-1]);

            //string[] insancıklar = { "said:", "gül:", "nisa:", "muhammed:" };
            //Console.WriteLine("Favori insan numaranızı girin: \n1-said\n2-gül\n3-nisa\n4-muhammed");
            //Console.WriteLine();
            //int özellik = int.Parse(Console.ReadLine());
            //string[] özellikleri = { "Çok konuşuyor", "güzel", "özel", "hiç konuşmuyor" };
            //Console.WriteLine(insancıklar[özellik - 1] + " " + özellikleri[özellik - 1]);

            //string[] ducks = { "ördekboi", "gowner", "watson", "nıeve", "architechra", "attalian" };
            //Console.WriteLine("altı ördek bir katil ama sence kim? ördeğin numarasını gir.\n1-ördek boi\n2-gownwer\n3-watson\n4-nieve\n5-architechra\n6-attalian");
            //Console.WriteLine("----------------------");
            //int x = int.Parse(Console.ReadLine());
            //Console.WriteLine(ducks[x - 1] + " adlı ördek katildi iyi iş çıkardın <3");

            #endregion

            #region Hikayeli Uygulamalar

            //Console.WriteLine("bu sabah başıma ... numaralı olay geldi. (1-5 arası bir sayı)");
            //int c = int.Parse(Console.ReadLine());
            //Console.WriteLine("---------------------------------------------------------------");
            //switch (c)
            //{
            //    case 1: Console.WriteLine("bu sabah uyandığımda tavanda bir örümcek gördüm"); break;
            //    case 2: Console.WriteLine("bu sabah uyandığımda tavana baktım"); break;
            //    case 3: Console.WriteLine("bu sabah uyandığımda karımı gördüm"); break;
            //    case 4: Console.WriteLine("bu sabah uyandığımda ilk olarak telefonuma baktım"); break;
            //    case 5: Console.WriteLine("bu sabah uyandığımda yerdeki terliğime baktım"); break;
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("sonrasında ... numaralı olay oldu. (1-4 arası bir sayı)");
            //int a = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------------------------------------");
            //switch (a)
            //{
            //    case 1: Console.WriteLine("sonra onunla öpüştük"); break;
            //    case 2: Console.WriteLine("ben de sırtımı döndüm"); break;
            //    case 3: Console.WriteLine("ben de onu yedim"); break;
            //    case 4: Console.WriteLine("sonra dedim boşver"); break;
            //}
            //Console.WriteLine();
            //Console.WriteLine();
            //Console.WriteLine("son olarak da ... numaralı olay oldu. (1-5 arası bir sayı)");
            //int b = int.Parse(Console.ReadLine());
            //Console.WriteLine("--------------------------------------------------------------");
            //switch (b)
            //{
            //    case 1: Console.WriteLine("son olarak da altıma yaptım fışşşşşş"); break;
            //    case 2: Console.WriteLine("son olarak da kendimi elledim ve yattım"); break;
            //    case 3: Console.WriteLine("son olarak da yatağın altında ağladım"); break;
            //    case 4: Console.WriteLine("son olarak da ossurdum ohhh prrrrrrrrttt"); break;
            //    case 5: Console.WriteLine("son olarak da kafamı koyup uyudum"); break;
            //}

            Console.WriteLine("Muttalıp bayırlarına hoş geldiniz.\nBütün kararları doğru vermeli ve sapasağlam hikayeyi tamamlamalısın. (Tabi doğru seçenek her zaman tek değildir.)");
            Console.WriteLine("Uyandın ve herkes yine göt göbek yatıyor. Bu sabah olacak olanlar senin kararında, ne yapıcaksın?");
            Console.WriteLine("1-elini yüzünü yıka.\n2-yemekhaneye git.\n3-sigaraya in.");
            int a = int.Parse(Console.ReadLine());
            if (a == 1)
            {
                Console.WriteLine("Elini yüzünü yıkadın. Ve artık kendini zinde hissediyorsun. Şimdi napıcaksın?");
                Console.WriteLine("1-yemekhaneye git.\n2-salihin ayaklarını gıdıkla.\n3-samete kibrit çak.");
                int a1 = int.Parse(Console.ReadLine());
                if (a1 == 1)
                {
                    Console.WriteLine("Yemekhaneye gittin. Sinan'ın pususunu gördün. ne yapıcaksın?");
                    Console.WriteLine("1-gizlice yemekhaneye sız.\n2-yemeği yemekhanedeki çöpten yemeye karar ver.\n3-Geri dön ve Eren'in kolasına çöreklen.");
                    int a11 = int.Parse(Console.ReadLine());
                    if (a11 == 1)
                    {
                        Console.WriteLine("Başarılı bir şekilde yemekhaneye sızdın ve yemeğini yedin. Şimdi napıcaksın?");
                        Console.WriteLine("1-odaya dön.\n2-bi sigara yak.\n3-porsuk çaya kahve içmeye git.");
                        int a111 = int.Parse(Console.ReadLine());
                        if(a111 == 1)
                        {
                            Console.WriteLine("Odaya döndün ve bir süre telefonda takıldıktan sonra sıkıldın. Said sana bitki çayı önerdi ve Salih Clash atmak istiyor. Ne yapıcaksın?");
                            Console.WriteLine("1-bitki çayını al ve clash at.\n2-Eren'e pandik at.\n3-Emre'yle sigaraya in.");
                            int a1111 = int.Parse(Console.ReadLine());
                            if (a1111 == 1)
                            {
                                Console.WriteLine("Çayını aldın ve Salih'le clash atmaya başladın. Emre de Yunus'la takım oldu ve yenildiler. Emre çok sinirlendi ve yatağını sallamaya başladı. Kaynar çay üstüne döküldü ve taşakların alev aldı. Herkes gülmekle meşgul olduğu için hastaneye gidemedin (ATEŞ TOPU SON)");
                            }
                            if (a1111 == 2)
                            {
                                Console.WriteLine("Eren'e pandik attın. Bunun üzerine Eren bağlantılarını kullandı ve gizli bir Geredeli olan Acunu aradı ,survivorda odadan atılcak kişi için oy verildi. Seçimi kazandın ve oda halkı tarafından pencereden atıldın.(KALDIRIM BOKU SON) ");
                            }
                            if (a1111 == 3)
                            {
                                Console.WriteLine("Emre'yle sigaraya indin, sigara içtiniz ve geldiniz. Şimdi napıcaksın?");
                                Console.WriteLine("1-yurdun arkasında 31 çek.\n2-akşam yemeğine elma kafeye git.");
                                int a11113 = int.Parse(Console.ReadLine());
                                if (a11113 == 1)
                                {
                                    Console.WriteLine("ohhhhhhhh, yurdun arkasındaki kaldırımda işini çözerken bir anda memur geldi. Yüzüne sert bir ifadeyle baktı ve yanına ilişti. Onu çağırmadığın için sana kızdı ve üstüne boşaldı. Dölden öldün.(31 SON)");
                                }
                                if (a11113 == 2)
                                {
                                    Console.WriteLine("Akşam yemeğine elma kafeye gittin ve bazlomos yedin. Mükemmel günü bir sigara ile taçlandırdın. Bravo.(MÜK MUTLU SON)");
                                }
                            }
                        } 
                        if (a111==2)
                        {
                            Console.WriteLine("Sigara içerken için inanılmaz bir sıçma arzusuyla doldu ama yukarı çıktığında tuvaletin dolu olduğunu gördün. Kapıyı çaldın ama Yunus sakallarını kestiği için seni duymadı. Napıcaksın?");
                            Console.WriteLine("1-pencereden sıç.\n2-Salih'den şişe iste ve alaturkaya git.\n3-tuvaletin kapısına sıç.");
                            int a1112 = int.Parse(Console.ReadLine());
                            if (a1112 == 1)
                            {
                                Console.WriteLine("Pencereye gittin ve bütün gücünle ıkındın. O kadar mükemmel sıçtın ki bir güvercin vurdun!! Napıcaksın?");
                                Console.WriteLine("1-Götünü pencerenin önündeki mermere sil.\n2-Güvercine bakmaya git.\n3-Aşağıda bu şaheseri izleyen insanlara el salla.");
                                int a11121 = int.Parse(Console.ReadLine());
                                if ( a11121 == 1)
                                {
                                    Console.WriteLine("Mermerin üzerindeki güvercin boklarından götüne kuş gribi bulaştı ve artık olup olmadık zamanlarda götünden hapşırıyorsun. İnsan içine çıkamaz oldun ve hayatın bitti.(GÜVERCİN LANETİ SON)");
                                }
                                if (a11121 == 2)
                                {
                                    Console.WriteLine("Güvercine bakmaya gittiğinde etrafında başka güvercinler olduğunu fark ettin. Seni çatıya yatırdılar ve amcam için, babam için nidalarıyla bağırta çağırta siktiler. Sonrasında kızgın güvercin sürüsü seni çatıdan aşağı attı.(GÜVERCİN GRUP SON)");
                                }
                                if (a11121 == 3)
                                {
                                    Console.WriteLine("İnsanlar bu büyüleyici olaydan çok etkilendi ve seni liderleri olarak görmeye başladılar. Kısa sürede sıçış adam lakabıyla dünyanın dört bir yanında nam saldın.(SIÇIŞ FENOMENİ SON)");
                                }
                            }
                            if (a1112 == 2)
                            {
                                Console.WriteLine("Salihden şişe istedin ve sana verdi. Ama bu esnada hangi kata gitmen gerektiğini sormadın ve çoktan asansördesin. Napıcaksın?");
                                Console.WriteLine("1-Birinci kata git.\n2-İkinci kata git.\n3-Üçüncü kata git.\n4-Dördüncü kata git.\n5-Geri dönüp salihe sor.");
                                int a11122 = int.Parse(Console.ReadLine());
                                if (a11122 == 1)
                                {
                                    Console.WriteLine("Birinci kata gittin ve rahat rahat sıçtın. O kadar büyük bir rahatlık geldi ki günün kalnında yatmaya karar verdin. Tuvalet artık kullanılamaz halde tabi.(SIÇABİLMİŞ SON)");
                                }
                                if (a11122 == 2)
                                {
                                    Console.WriteLine("İkinci kata gittin ve çömeldin tam sıçacakken götüne bir yılan kaçtı. Yılandan dolayı sıçamadın ve götün patladı.(YILAN TIPASI SON);");
                                }
                                if (a11122 == 3)
                                {
                                    Console.WriteLine("Üçüncü kata gittin ve tuvalete çömeldin. Bu sırada bir ses duydun ve tavan üstüne çöktü. Hayat üçgenine sıkışmışken kendini tutamadın ve sıçtın. Delik doldu ve kendi bokunda boğularak öldün.(BOK DELİĞİ SON)");
                                }
                                if (a11122 == 4)
                                {
                                    Console.WriteLine("Dördüncü kata koştun ve hızlıca çömeldin. Sıçarken bir çatırdı geldi ve yer çöktü. Ne yazık ki yıkıntıda inşaat demirinin götüne girmesi sonucu hayatını kaybettin.(DEVASA TETANOZ SON)");
                                }
                                if(a11122 == 5)
                                {
                                    Console.WriteLine("Geri dönmeye çalıştın ama artık çok geç koridorun ortasında pantula patladın. Odaya sürünürken radyoaktif bok seni yavaş yavaş öldürdü.(BOKİNYUM SON)");
                                }
                            }
                            if (a1112 == 3)
                            {
                                Console.WriteLine("Tuvaletin kapısına sıçtın. Banyodan çıkarken yunus bokuna bastı ve kaydı. Düşerken kafasını çarptı ve hayatını kaybetti. Cinayetten 10 yıl hapis yedin.(MAPUS DALLARI SON)");
                            }
                        }
                        if (a111 == 3)
                        {
                            Console.WriteLine("Kahve içmek için rastgele bir mekana girdin ve bir espresso aldın. Lakin 150 lira ödedin ve 20ml soğuk çay servis ettiler. Naparsın?");
                            Console.WriteLine("1-Soğuk çayımı içer giderim.\n2-Kavga çıkartırım.\n3-Cimere şikayet ederim.");
                            int a1113 = int.Parse(Console.ReadLine());
                            if (a1113 == 1)
                            {
                                Console.WriteLine("Soğuk çayını içtin ve gittin, seni iyi tokatladılar.(HAHAHAHAHH ENAYİ SON)");
                            }
                            if (a1113 == 2)
                            {
                                Console.WriteLine("Kavga çıkarttın ama anlaşılan mekan italyan mafyasına aitmiş. Topuklarına sıktılar.(MAFYA SON)");
                            }
                            if (a1113 == 3)
                            {
                                Console.WriteLine("Cimere şikayet ettin. Mekanı kapattılar ama anlaşılan mekan italyan mafyasına aitmiş. Üniversiteye giderken yolda seni sıkıştırdılar ve intikam almak istiyorlar. Napıcaksın?");
                                Console.WriteLine("1-Abi bokunuzu yiyim abi.\n2-Kaçmaya çalış.\n3-yoldan geçen kamyonun arkasına atla.");
                                int a11133 = int.Parse(Console.ReadLine());
                                if(a11133 == 1)
                                {
                                    Console.WriteLine("Mafya sana tuhaf tuhaf baktı anlaşılan türkçe bilmiyorlar. Kafana sıktılar.(KURŞUNLU SON)");
                                }
                                if (a11133 == 2)
                                {
                                    Console.WriteLine("Kaçmaya çalıştın. Yola atladın ve koşmaya başladın ama kamyonun geldiğini göremedin.(BOK YOLUNA GİTTİ SON)");
                                }
                                if (a11133 == 3)
                                {
                                    Console.WriteLine("Kamyon anlaşılan Karadeniz istikametine gidiyor. Mafya arabalarla peşine düştü ve Karadenize kadar seni takip etti. Kamyoncu köyün birinde kenara çekti ve bir anda her yer silahlı lazlarla doldu. Napıcaksın?");
                                    Console.WriteLine("1-Kamyoncudan yardım iste.\n2-Kamyonun arkasında uyuya kaldığını ve mafyanın kamyoncunun peşinde olduğunu söyle.\n3-köyden olduğunu söyle ve lazların arasına karış.");
                                    int a111333 = int.Parse(Console.ReadLine());
                                    if (a111333 == 1)
                                    {
                                        Console.WriteLine("Kamyoncu teklifini kabul etti ve mafyayla savaşa girdi. Arbedede yaralandın. Lazlar sana yardım etmek için suni teneffüs yapmaya karar verdi. Laz adamın biriyle öpüşürken kan kaybından öldün.(LAZ KİSS SON)");
                                    }
                                    if(a111333 == 2)
                                    {
                                        Console.WriteLine("Kamyoncu buna inandı ve mafyayla savaşmaya gitti ama cebinde ne para var ne de yolu biliyorsun. Artık laz köyünde yaşamaya mahkumsun.(LAZ ADAM SON)");
                                    }
                                    if (a111333 == 3)
                                    {
                                        Console.WriteLine("Lazlar durumu çaktı ve önce seni sonra bütün mafyayı vurdular. Laz köyüne usulüne uygun gömüldün.(MEZAR SON)");
                                    } 
                                }
                            }
                        }
                    }
                    if (a11 == 2)
                    {
                        Console.WriteLine("yemekhanedeki çöpte 25 farklı çorbanın karışımı olan çorbayı buldun miden çok bulandı ama içtin artık toksun şimdi napıcaksın?");
                        Console.WriteLine("1-üniversteye takılmaya git.\n2-Samet'le köye git.\n3-yurtta gezintiye çık.");
                        int a112 = int.Parse(Console.ReadLine());
                        if (a112 == 1)
                        {
                            Console.WriteLine("Üniversiteye takılmaya gittin ve bir kız gördün. Aşık oldun. Tam her şey güzel giderken midende bir hareketlenme hissettin ve kızın üstüne kustun. Utancından kalp krizi geçirdin ve öldün.(CRİNGE SON)");
                        }
                        if (a112 == 2) 
                        {
                            Console.WriteLine("Köye gittiniz market yaptınız ve çay içtiniz. Şimdi napıcaksın?");
                            Console.WriteLine("1-tütüncü dayıya git\n2-yurda dönmek için otostop çek.\n3-köy pazarını gez.");
                            int a1122 = int.Parse(Console.ReadLine());
                            if (a1122 == 1)
                            {
                                Console.WriteLine("tütüncü dayıya gittiniz, Dayı sametin borcunu istedi ve ikinizde de para yok. Bunun üzerine dayı sinirlendi ve size silah çekti napıcaksın?");
                                Console.WriteLine("1-borcu yangın merdiveni usulü öde.\n2-sameti sat.\n3-mermiye kafa at.");
                                int a11221 = int.Parse(Console.ReadLine());
                                if (a11221 == 1)
                                {
                                    Console.WriteLine("Dayı sizi yağlı yağlı sikti ve hepatit c kaptın. Hastalıktan kurtulamadın ve ne yazık ki öldün.(YAĞLI YAĞLI SON)");
                                }
                                if (a11221 == 2) 
                                {
                                    Console.WriteLine("Samet'i sattın ve kaçtın. Akşamına Samet odaya döndü. Dayıyı da beraberinde getirdi. İkisi seni tutup yağlı yağlı siktiler. (SAMET VE DAYI SON)");
                                }
                                if (a11221 == 3)
                                {
                                    Console.WriteLine("Mermiye kafa attın ve anlaşılan kuru sıkıymış kafan kanadı ve dayı çok korktu. Elinde her şeyi sana verdi ve gitmen için yalvardı. Artık tonla paran ve bir tütüncü dükkanın var.(ZENGİN SON) ");
                                }
                            }
                            if(a1122 == 2)
                            {
                                Console.WriteLine("Otostop çekmeye karar verdiniz. Adamın biri sizi aldı ve Giderken kenara çekti. Samete dönüp 50 liram nerde amına koyduğum dedi. Ne dediyseniz dinlemedi. İkinizi de vurdu ve muttalıbın boklu bataklığına attı.(BOK SON)");
                            }
                            if (a1122 == 3) 
                            {
                                Console.WriteLine("Köy pazarını gezerken çok sevdiğin şeyler buldun ve çok ucuza satın aldın. Gidip m4'e bindin ve döndün. Müq bir gündü ve pazarda çok eğlendin.(BAZAR MUTLU SON)");
                            }
                        }
                        if (a112 ==3)
                        {
                            Console.WriteLine("Yurtta gezinirken bir kızla karşılaştın ve açık açık sana yürüyor. Napıcaksın?");
                            Console.WriteLine("1-çiftleşme dansı yap.\n2-kıza şiir oku.\n3-otistik hareketler yap ve ordan uzaklaş.");
                            int a1123 = int.Parse(Console.ReadLine());
                            if (a1123 == 1)
                            {
                                Console.WriteLine("Kız sana fena düştü, ve birlikte dans etmeye başladınız. İşler çok hızlı ilerledi ve kız seni kazan dairesinde görmek istiyor. Napıcaksın?");
                                Console.WriteLine("1-başka bir yer öner\n2-kazan dairesine git.\n3-ben iman yolundayım de ve ordan git.");
                                int a11231 = int.Parse(Console.ReadLine());
                                if (a11231 == 1)
                                {
                                    Console.WriteLine("Odaya çıkamyı önerdin. Odaya çıkarken asansör bozuldu ve asansörde kaldınız. Durumu memurlara açıklayamdın ve yurttan atıldın.(SEVİŞEMEYEN SON)");
                                }
                                if (a11231 == 2)
                                {
                                    Console.WriteLine("Kazan dairesinde iş pişirirken başka öğrencilere yakalandınız. Vidyolarınız her yere yayıldı ve Pornhub'tan iş teklifi aldın.(PORNSTAR SON)");
                                }
                                if (a11231 == 3)
                                {
                                    Console.WriteLine("Kız sana kafayı taktı ve gece uyurken seni boğdu. Cesedine neler yaptığı bilinmiyor.(CESET PURNA SON)");
                                }
                            }
                            if (a1123 == 2)
                            {
                                Console.WriteLine("Kıza cumhuriyet şiiri okudun ve herkes çok etkilendi. Birlikte parti kurup iktidara yerleştiniz.(YAŞASIN CUMHURİYET SON)");
                            }
                            if (a1123 == 3) { Console.WriteLine("İman yolun kızı çok etkiledi. Kız ailenle konuştu ve görücü usulü evlendiniz ve sabahlara kadar mercimek fırınlıyosun.(DEHŞET PURNA SON)"); 
                            }
                        }
                    }
                    if(a11 == 3)
                    {
                        Console.WriteLine("Eren'in kolasına çöreklendin. Eren bunu gördü ve sorun etmedi. Ama ne yazık ki kola mideni deldi. Emre'den ilaç istedin ama komik olacağı için vermedi. Can çekişerek öldün.(EMRE KOMİK SON)");
                    }
                }
                if (a1 == 2)
                {
                    Console.WriteLine("Salihin ayaklarını gıdıklarken ayaklarını ağzına soktu (sağlık-100). Zehirden hastaneye kaldırıldın ve doktorlar seni kurtaramadı.(AYAK SON)");
                }
                if (a1 == 3)
                {
                    Console.ForegroundColor = ConsoleColor.Black;
                    ConsoleColor[] colors = {ConsoleColor.DarkRed, ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Red };
                    int index = 0;
                    while (true)
                    {
                        Console.BackgroundColor = colors[index];
                        Console.Clear();
                        Console.WriteLine("Samete kibrit çaktın. Tam gülerken bütün oda havaya uçtu ve hepiniz öldünüz. Bravo arık haberlerdesiniz.(ÜNLÜ SON)");
                        Thread.Sleep(800);
                        index++;
                        if (index >= colors.Length) index = 0;                    
                    }
                }   
            }
            if (a == 2)
            {
                Console.WriteLine("Yemekhaneye gittin ama o da ne? Sinan kahvaltı için seni orda bekliyor. Ne yapıcaksın?");
                Console.WriteLine("1-Gizlice gitmeye çalış.\n2-'baane aw' de ve yemeğe git.\n3-yemekhaneden KAÇ!");
                int a2 = int.Parse(Console.ReadLine());
                if (a2 == 1)
                {
                    Console.WriteLine("Gizlice gitmeye çalışıyordun fakat çapak gözüne kaçtı ve bağırınca yakalandın. Esogü'ye hastaneye kaldırıldın. Doktor 1 ay yatman gerektiğini söyledi ve artık her sabah kahvaltını Sinan'la yapıyorsun.(SİNAN SON) ");
                }
                if (a2 == 2)
                {
                    Console.WriteLine("Çok da takmadın ama Sinan sana yapıştı ve birlikte masaya oturdunuz. O kadar sıkıldın ki yemekhanede uyuya kaldın. Uyurken birisi götünü elledi ve uyandın. Kim yaptı derken Hakan'ı gördün ve sevişmeye başladınız.(HAKAN YAVAŞ CİĞERİMİ SÖKTÜN SON)");
                }
                if (a2 == 3)
                {
                    Console.WriteLine("Yemekhaneden kaçtın ama kaçarken cüzdanını düşürdün ve hala açsın. Ne yapıcaksın?");
                    Console.WriteLine("1-Çöpten ye.\n2-Cüzdanı geri almaya çalış.\n3-Köpekleri şiş kebap yap");
                    int a23 = int.Parse(Console.ReadLine());
                    if (a23 == 1)
                    {
                        Console.WriteLine("Çöpten yediklerinden zehirlendin.(e yani) Zehirlendin ve etrafında sadece npc'ler olduğu için ölüme terk edildin.");
                    }
                    if (a23 == 2)
                    {
                        Console.WriteLine("Cüzdanı geri almaya çalışırken güvenlik seni gördü. Kendi cüzdanın olduğunu söylemye çalışırken güvenliğin dalyaraklık yaptığını fark ettin. Ne yapıcaksın?");
                        Console.WriteLine("1-Güvenliği sik.\n2-Hakanı ara.\n3-Kaç!");
                        int a232 = int.Parse(Console.ReadLine());
                        if (a232 == 1)
                        {
                            Console.WriteLine("Güvenlik bundan çok büyük zevk aldı ve artık her gece birlikte yatıyorsunuz ama güvenliğin eşi bu olanları öğrendi ve siz yataktayken elinde silahla içeri girdi, ne yaparsın?");
                            Console.WriteLine("1-Bütün suçu güvenliğe at.\n2-kadını da davet et.\n3-Güvenliğin kel kafasına şaplak at ve yiyişmeye devam et.");
                            int a2321 = int.Parse(Console.ReadLine());
                            if (a2321 == 1)
                            {
                                Console.WriteLine("Bütün suçu güvenliğe attın ama güvenlik kamera kayıtlarını ortaya çıkardı. Kocasını siktiğin için kadın seni vurdu.(GAY ZAMPARA SON)");
                            }
                            if (a2321 == 2)
                            {
                                Console.WriteLine("Kadını da davet ettin ama bu işe yaramadı. Anlaşılan sadece erkekleri etkileyebiliyorsun. Vuruldunuz.(BAYLAR GAYLAR SON)");
                            }
                            if (a2321 == 3)
                            {
                                Console.ForegroundColor = ConsoleColor.Black;
                                ConsoleColor[] colors = { ConsoleColor.DarkRed, ConsoleColor.Red, ConsoleColor.DarkYellow, ConsoleColor.Yellow, ConsoleColor.Magenta, ConsoleColor.Cyan, ConsoleColor.Blue, ConsoleColor.DarkBlue, ConsoleColor.Gray, ConsoleColor.DarkGreen, ConsoleColor.Green};
                                int index = 0;
                                while (true)
                                {
                                    Console.BackgroundColor = colors[index];
                                    Console.Clear();
                                    Console.WriteLine("Güvenlikle aşk hayatınız son hız devam ediyor. Kadın gördüklerine inanamadı ve kendi kafasına sıktı. Ardından öksüz çocuklar için evlenmeye karar verdiniz.(GAY AŞIKLAR SON) \n\n\n                       I JUST WANNA BE PART OF YOUR SYMPHONYYYYYY");
                                    Thread.Sleep(200);
                                    index++;
                                    if (index >= colors.Length) index = 0;
                                }
                            }

                        }
                        if (a232 == 2)
                        {
                            Console.WriteLine("Hakanı aradın ve hakan geldi. Ama bir anda güvenlikle yiyişmeye başladılar. Sonra sana döndü ve yurttan atıldığını söyledi.(KILICI KESKİN SON)");
                        }
                        if (a232 == 3)
                        {
                            Console.WriteLine("Kaçmaya karar verdin ama güvenlik çok hızlı koşuyor. Seni yakaladı ve cüzdanı senden alıp gitti. Cüzdanı geri getirdiğinde içinde para yoktu. Kusura bakma krdşm içinde zaten para yoktu dedi ve gitti. Bu süreçte açlığa daha fazla dayanamadın ve öldün.(ÖDLEK FAKİR SON");
                        }
                    }
                    if (a23 ==3)
                    {
                        Console.WriteLine("Köpeklerden şiş kebap yaptın. Olayın enterasan kısmı ise etin tadı aynı yemekhane yemeği gibi... Neyse, napıcaksın?");
                        Console.WriteLine("1-odaya git.\n2-Salihle cumaya git.\n3-Sametle bara git.");
                        int a233 = int.Parse(Console.ReadLine());
                        if (a233 == 1)
                        {
                            Console.WriteLine("Odaya geldin, bir süre youtube'da takıldın ve canın çok sıkıldı. Napıcaksın?");
                            Console.WriteLine("1-odaya agalarla pusu at.\n2-Tuvalete git.\n3-Emre'nin götünde şişe patlat.");
                            int a2331 = int.Parse(Console.ReadLine());
                            if (a2331 == 1)
                            {
                                Console.WriteLine("Odaya pusu attınız. Sinan odaya geldi ve Eren'in cipslerine çöreklendi. Çok hızlı bir şekilde prezervatifleri taktınız ve 7 kişi üstüne atladınız, ardından onu çatur çutur siktiniz. Hepiniz yurttan atıldınız ama buna değdi.(KONDOM PUSUSU SON");
                            }
                            if (a2331 == 2)
                            {
                                Console.WriteLine("Tuvalete gittin. Ve kapağı açınca gördüğün şey karşısında şaşkına döndün. Sahipsiz bir kondom bulmuştun ve kimse onun kendisine ait olduğunu söylemiyordu. Bunun üzerine kondomun sahibini bulmaya karar verdin. Napıcaksın?");
                                Console.WriteLine("1-DNA testine yolla.\n2-Sifonu çek. Ve bütün bunları geride bırak.\n3-Tuvalete bu iş nasıl yapılır göster. ");
                                int a23312 = int.Parse(Console.ReadLine());
                                if (a23312 ==1)
                                {
                                    Console.WriteLine("Kondomu DNA testine yolladın ve gelen sonuca inanamadın. Bunun gerçekliğini görmek istedin ve tuvalete kamera taktırdın. Sabah kalktığında kamera kayıtlarını izlemeye gittin. DNA testi sonuçları doğruymuş. Kamerada Veysel'in ağlayarak 'Neden ben gittim neden' diyerek kondoma patladığını gördün. Artık yemekhanede onu gördüğünüzde yüzünüzü çeviriyorsunuz. Sayende bütün odanın yeni bir travması var.");
                                }
                                if (a23312 == 2)
                                {
                                    Console.WriteLine("Sifonu çektin ve hiç olmamış gibi davrandın. Ama oda en çok senden şüpheleniyor. Nihayetinde kim böyle bir şeyi başkasına göstermeden sifonu çeker ki...(ŞÜPHELİ SON)");
                                }
                                if (a23312 == 3)
                                {
                                    Console.WriteLine("Tuvalete bu iş nasıl yapılır göstermeye karar verdin. Çok seri bir şekilde asılmaya başladın. ĞAAAHHHHH. Bu esnada içeri temizlik görevlisi abi girdi. Ve ne yaptığına anlam veremedi. Görünüşe göre tuvalet gözünü kör etmiş ve kapıyı kapatmayı unutmuşsun. Abiye dönerken yanlışlıkla üstüne boşaldın. Adam şok oldu ve kalp krizi geçirdi. Artık travman var ve elin asla çüküne gitmiyor.(SİKİ TUTAMIYON SON)");
                                }
                            }
                            if (a2331 == 3)
                            {
                                Console.WriteLine("Emre'nin götünde şişe patlatmak için şişeyi büktün ama Emre olanları sezdi. Sen arkasını hedef almaya çalıştıkça dönmeye başladı. Sen de odanın içinde koşturmaya başladın. Havaya atladın ve hedefi vurdun ama ne yazık ki bu esnada kafan da ranza demirine vurdu. Bayıldın. Olayın kötü kısmıysa sen baygınken Emre senden intikamını aldı. (SAMET BAYILDI SON)");
                            }
                        }
                        if (a233 == 2)
                        {
                            Console.WriteLine("Salihle cumaya gittiniz. Caminin kapısında dilenen teyze sana 'Evladım Allah sınavlarını geçsin.' dedi. Bir anda üniversiteden bir mesaj aldın ve 4 ortalamayla üniversiteyi bitirdiğini öğrendin. Tebrikler! (MEZUN SON)");
                        }
                        if (a233==3)
                        {
                            Console.WriteLine("Sametle bara gittiniz. Ama cebinde hiç para yok ve eğlenmek istiyorsun. Napıcaksın?");
                            Console.WriteLine("1-Dans etmeye başla.\n2-Masadaki şüpheli adama yaklaş.");
                            int a2333 = int.Parse(Console.ReadLine());
                            if (a2333 == 1)
                            {
                                Console.WriteLine("Dans etmeye başladın. Ve dayının biri dansını çok beğendi. Bütün yediğiniz içtiğinizi ödeyeceğini söyledi ve sizi cluba götürdü. Sametle dans edip yiyip, içip, sıçtınız. Gün belki güzel başlamadı ama görünüşe göre oldukça iyi bitti.(RAMBO DAYI SON)");
                            }
                            if (a2333 == 2)
                            {
                                Console.WriteLine("Masadaki şüpheli adama yaklaştın. Ve bir anda sana dönüp, sana bir şey söylicem ama alınmak yok dedi. Tamam dayı dedin ve dayı devam etti. Şimdi sana bir soru sorcam, eğer bilirsen biran benden ama bilemezsen sen bana bir bira alıcan dedi. Kim olduğumu bil dedi. Ne yapıcaksın? ");
                                Console.WriteLine("1-iddiaya gir.\n2-bi git işine dayı.");
                                int a23332 = int.Parse(Console.ReadLine());
                                if (a23332 == 1)
                                {
                                    Console.WriteLine("Soruyu cevaplayacağını söyledin. Ve dayı cesaretinden etkilendi. Sana kim olduğunu söylemeye karar verdi. Ardından kendisinin hewal Ercan olduğunu öğrendin. Sana baktı ve dedi ki 'Ben hewal Ercan'ım doğru mu?' sen de doğrudur dedin. ama dayı doğru mu diye sormaya devam etti ve sonsuz bir döngüye girdiniz. Ne yapıcaksın?");
                                    Console.WriteLine("1-bütün gücünle doğru diye bağır.\n2-polisi ara.");
                                    int a233321 = int.Parse(Console.ReadLine());
                                    if(a233321 == 1)
                                    {
                                        Console.WriteLine("Bağırdın ve dayı da bütün gücüyle 'DOĞRU MUUU' diye bağırdı. Parlamaya başladınız ve hewal Ercan evrenine geçtiniz.(HEWAL ERCAN SON)");
                                    }
                                    if (a233321==2)
                                    {
                                        Console.WriteLine("Polisi aradın ve bir bok olmadı. Polis sana adamı Kürt diye içeri mi alalım mal dedi.(BU NE BİÇİM SON SON)");
                                    }
                                }
                                if (a23332 == 2)
                                {
                                    Console.WriteLine("Dayıya işine gitmesini söyledin. Ve dayı bu hareketini beğenmedi. Ezbırçime bowe taq dedi ve seni bıçakladı.(HEWAL SALDIRISI SON)");
                                }
                            }
                            if (a2333 == 3)
                            {
                                Console.WriteLine("Mal mısın olm böyle bir seçenek mi var? (SİKTUMUNUN SİĞİRİ SON)");
                            }
                        }
                    }
                }
            }
            if (a == 3)
            {
                Console.WriteLine("Sigaraya indin. Yemekhanede sinanın pusu attığını gördün. Ama karnın da aç ne yapıcaksın?");
                Console.WriteLine("1-dışarıdan yemek söyle.\n2-Odanın kıyısında köşesinde yemek ara.\n3-Said'in labnesine ÇÖK.");
                int a3 = int.Parse(Console.ReadLine());
                if (a3 == 1)
                {
                    Console.WriteLine("Dışarıdan yemek yemeye karar verdin nerden alacaksın?");
                    Console.WriteLine("1-oruç\n2-baraka\n3-çiçek pide. ");
                    int a31 = int.Parse(Console.ReadLine());
                    if (a31 == 1)
                    {
                        Console.WriteLine("Oruçtan yemek söyledin aradan günler geçti ve hala bekliyorsun. Yerdeki tozları yalıyarak hayatta kalmaya bile çalışdın ama nafile, açlıktan öldün.(ORUÇ SON)");
                    }
                    if (a31 == 2)
                    {
                        Console.WriteLine("Barakadan yemek söyledin. Bol yagli geldi ve ekstra para ödemek zorunda kaldın(-50tl). Moralin bozuldu ve yemek sana ağırlık yaptı napıcaksın?");
                        Console.WriteLine("1-camış gibi yat.\n2-götünü kaşı.\n3-yunusla tartış.");
                        int a312 = int.Parse(Console.ReadLine());
                        if (a312 == 1)
                        {
                            Console.WriteLine("Camış gibi yatıyordun eren sigaraya çağırdı ama sg dedin. Çakmakla sana şaka yapmaya çalışırken yatağı yaktı. Yanan yatakta can çekişerek öldün.(ŞAKA YAPTIK KANKA SON)");
                        }
                        if (a312 == 2)
                        {
                            Console.WriteLine("Götünü kaşıyorsun ve hazzın doruklarındasın ama yağlı elin yanlışlıkla götüne kaçtı. Ne yazık ki elini uzun bir süre çıkaramadın ve bağırsağın patladı.(BOK TORBASI SON)");
                        }
                        if (a312 == 3)
                        {
                            Console.WriteLine("Yunusla tartışmaya girdin ve zamanla bütün oda dahil oldu. Tebrikler artık odada huzur yok. Amınakoydunuz. Zamanla oda dağıldı ve artık kürtlerle aynı odada kalıyorsun.(HEWAL SON)");
                        }
                    }
                    if (a31 == 3)
                    {
                        Console.WriteLine("Çiçek pideden yemeğini yedin ve doydun. O esnada bir telefon geldi. Telefondaki adam sana hewal Ercan sen misin dedi napıcaksın?");
                        Console.WriteLine("1-Evet hewal Ercan benim.\n2-tanımıyorum.\n3-ben sizin genel kurmay cumhurbaşkanı başbakanınızım.");
                        int a313 = int.Parse(Console.ReadLine());
                        if (a313 == 1)
                        {
                            Console.WriteLine("Hewal Ercan olduğuna inandılar ve sana pkk'nın gizli üslerinin konumlarını verdiler napıcaksın?");
                            Console.WriteLine("1-MİT'e bildir.\n2-üsse git.\n3-onlara şakalandıklarını söyle, ŞAKALANDIN DOSTUM.");
                            int a3131 = int.Parse(Console.ReadLine());
                            if (a3131 == 1)
                            {
                                Console.WriteLine("MİT'e gittin ve Hakan Fidanla özel görüşmeler gerçekleştirdin. Üsleri bombaladınız ve onur madalyası aldın. (HALK KAHRAMANI SON)");
                            }
                            if (a3131 == 2)
                            {
                                Console.WriteLine("Üsse gittin silah zoruyla pkk'ya katıldın. Ama mekanı bir anda sat komandoları ve Hakan Fidan bastı. Tam kurtuldum derken MİT'in telefonuna eriştiğini öğrendin. Yaptıkların cezasız kalmadı ve MİT tarafından içeri atıldın.(HAKAN FİDAN SON)");
                            }
                            if (a3131 == 3)
                            {
                                Console.WriteLine("ONLARI ŞAKALADIN SEN HEWAL ERCAN DEĞİLSİN. Bu duydukları hewallerin hoşuna gitmedi ve telefonun bir anda patladı.(ŞAKALANDIN SON)");
                            }
                        }
                        if (a313 == 2) 
                        {
                            Console.WriteLine("Hewal Ercan'ı tanımadığını söyledin ve telefonu kapadın ne olduğunu anlayamdın. Şimdi napıcaksın?");
                            Console.WriteLine("1-Odayı temizle.\n2-yemek sonrası sigarasına in.\n3-yurttaki odaları gez.");
                            int a3132 = int.Parse(Console.ReadLine());
                            if (a3132 == 1)
                            {
                                Console.WriteLine("Odayı temizlemeye başladın, odayı foşur foşur temizliyorsun ve o anda çekirdekleri temizlerken eline kabukların içinden bir iğne battı. Anlaşılan iğne Eren'in parfüm deneylerinin bir parçasıymış. Mutasyona uğradın ve esans adama dönüştün, artık ossuruğun hacı misi kokuyor ve ortalıkta tütsü gibi geziyorsun.(TÜTSÜ SON)");
                            }
                            if (a3132 == 2)
                            {
                                Console.WriteLine("Sigaraya indin. Ve bir anda etrafın ışıklarla doldu. Yukarıya doğru bir güç tarafından çekiliyorsun. Bir delikten girdin ve etrafında siyah gözlü yeşil yaratıklar var. Seni bir masaya bağladılar ve bayılttılar. Uyandığında yatağındaydın ama bir eksiklik vardı. Tuvalete gittiğinde TAŞŞAKLARININ olmadığını fark ettin. Anlaşılan uzaylılar tarafından kısırlaştırıldın.(EV KEDİSİ SON)");
                            }
                            if (a3132 == 3)
                            {
                                Console.WriteLine("Merakın yenik düştün ve yurttaki odaları gezmeye karar verdin. Rastgele odalar belirledin. Şimdi istediğine gidebilirsin.");
                                Console.WriteLine("1-H blok 403 numaralı odaya git.\n2-H blok 401 numaralı odaya git.\n3-H blok 305 numaralı odaya git.");
                                int a31323 = int.Parse(Console.ReadLine());
                                if (a31323 == 1)
                                {
                                    Console.WriteLine("403 numaralı odanın kapısına gittin ve içerden makina sesleri geliyor. Kapıyı açtın ve içeri girdin. Gördüğün şey karşısında dehşete kapıldın. Adamın birisi yurt odasına şahin park etmiş ve egzozundan takır tukur sikiyor. Ne kadar 'bahma gardaşım bahma ğaaaahhh bahma' dese de kafanı çeviremedin. Ve gördüklerin yüzünden büyük bir travma yaşadın.(MAKİNALAŞMAK İSTEYEN SON TRUM TİKİ TAK)");
                                }
                                if (a31323 == 2)
                                {
                                    Console.WriteLine("401 numaralı odanın kapısına gittin. İçerden hiçbir ses gelmiyor. Kapıyı araladın ve içeri girdin. Odaya ölüm sessizliği hakim. Açık pencerenin önünde hareket eden perde dışında odadaki hiçbir şey hareket etmiyor. Tam odadan çıkacakken bir anda odaya birisi spawn oldu. Bu sürekli telefonla konuşan npc adamdı. Yavaşça yerinden kalktı ve telefonunu açıp konuşmaya başladı. Yurttaki npc'lerin spawn merkezini buldun! Napıcaksın?");
                                    Console.WriteLine("1-Odayı yak.\n2-Telefon adamı öldür.\n3-Odanın kapısını kilitle ve git.");
                                    int a313232 = int.Parse(Console.ReadLine());
                                    if (a313232 == 1)
                                    {
                                        Console.WriteLine("Odayı yaktın ve artık yurda sessizlik hakim. İç huzuru buldun ve hayatının kalanına keşiş olarak devam etmeye karar verdin.(KEŞİŞ SON)");
                                    }
                                    if (a313232 == 2)
                                    {
                                        Console.WriteLine("Telefon adamı öldürdün. Ama yine spawn oldu. Sonra yine öldürdün ama yine spawn oldu. İş artık inada bindi. Ne kadar süre geçtiğini hatırlamıyorsun ve oda pencereye kadar kanla doldu. Kafayı sıyırdın ve intihar ettin.(YETER LAN YETEEER SON)");
                                    }
                                    if (a313232 == 3)
                                    {
                                        Console.WriteLine("Odanın kapısını kilitledin ve gittin. Aradan bir gün geçti sabah yine sigaraya inerken 401 numaralı odanın kapısından gelen gürültüler duydun. Kapıyı açıp içeri bakmaya karar verdin ama kapıyı aralayınca üstüne bir sürü telefon adam düştü. Anlaşılan map'te telefon adam olmadığı için bütün gün spawnlanmaya devam etmiş. Artık her yerdeler. Bir telefon adam kıyametine yol açtın ve yüzlerce telefon adamla aynı yerdesin. Psikolojin bu olanları kaldıramadı ve benliğini yavaş yavaş yitirdin. Artık sen de onlardan birisin.(NPC TELEFON ADAM SON)");
                                    }
                                }
                                 if (a31323 == 3)
                                {
                                    Console.WriteLine("305 Numaralı odaya gittin. Ses çıkardığın için senden rahatsız olduklarını söyleyip dalyarak dalyarak konuşmaya başladılar. Kafalarına kulaklık götlerine yarak takıp onları son ses turabi çamkıran dinlettin(İNTİKAM SON) ");
                                }
                            }
                        }
                        if (a313 == 3)
                        {
                            Console.WriteLine("Genel kurmay cumhurbaşkanı olduğunu söyledin. Telefondaki adam seni apo zannetti ve 'Kutsal hewal napmalıyız?' dedi. Napıcaksın?");
                            Console.WriteLine("1-pkk ya teslim olma çağrısı yap.\n2-kutsal hewal olarak başlarına geç.");
                            int a3133 = int.Parse(Console.ReadLine());
                            if(a3133 == 1)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Başardın pkk teslim oldu ve haberlere çıktı. Ülke çapında kutlamalar başladı. Birleşmiş milletlerden dünya barış ödülü aldın.(TR SERVER BARIŞ SON)");
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("************      *****************************");
                                Console.WriteLine("**********   *****  ***************************");
                                Console.WriteLine("*********   ************** ********************");
                                Console.WriteLine("*********   *************   *******************");
                                Console.WriteLine("**********   *****  ***** * *******************");
                                Console.WriteLine("************       ****************************");
                                Console.WriteLine("***********************************************");
                            }
                            if (a3133 == 2)
                            {
                                Console.BackgroundColor = ConsoleColor.DarkRed;
                                Console.ForegroundColor = ConsoleColor.White;
                                Console.WriteLine("Artık kutsal hewal sensin onları öyle inandırdın ki artık aponun kendisi bile apoyu sen sanıyor. Ama ne yazık ki telefon konuşmasını dinleyen tsk yurdu bombaladı. Hewallik hayallerin suya düştü.(TSK BOMBOM SON)");
                                Console.WriteLine("***********************************************");
                                Console.WriteLine("**           *****           ******   ***   ***");
                                Console.WriteLine("******   *********   *****   ******   **   ****");
                                Console.WriteLine("******   *********   **************   *   *****");
                                Console.WriteLine("******   *********           ******      ******");
                                Console.WriteLine("******   *****************   ******   *   *****");
                                Console.WriteLine("******   *********   *****   ******   **   ****");
                                Console.WriteLine("******   *********           ******   ***   ***");
                                Console.WriteLine("***********************************************");
                            }

                        }
                    }
                }
                if(a3 == 2)
                {
                    Console.WriteLine("Odanın kıyısını köşesini aramaya başladın. Bazalara bakarken Emre'nin yatağının altında siyah bir poşet buldun. İçerisinden 45cm titreşimli dildo çıktı!! Napıcaksın?");
                    Console.WriteLine("1-Dildoyu kullan.\n2-Poşeti yerine yavaşça geri bırak.\n3-Dildoyu güvenliğin kafsına at.");
                    int a32 = int.Parse(Console.ReadLine());
                    if (a32 == 1)
                    {
                        Console.WriteLine("Dildoyu kullanmaya çalıştın ama sana çok büyük geldi. Anlaşılan yeteri kadar tecrübeli değilsin. Dayanamadın ve çıkarmaya çalıştın ama başarısız oldun. Ne yazık ki götün delindi.(GÖT DELEN SON)");
                    }
                    if(a32 == 2)
                    {
                        Console.WriteLine("Poşeti yerine geri bıraktın. Aradan biraz zaman geçti ve Emre şüpheli davranıyor. Anlaşılan birinin poşeti açtığını anlamış. Odadaki herkesi tek tek öldürdü. Anlaşılan bu sır onunla birlikte mezara gidecek.(DİLDO KATLİAMI SON)");
                    }
                    if(a32 == 3)
                    {
                        Console.WriteLine("Dildoyu güvenliğin kafasına attın. Ama güvenlik beklendiğinin aksi tepkiler gösterdi. Altın bulmuş gibi sevindi ve alıp tuvalete koştu. Birkaç dakikanın ardından yüzünde devasa bir gülümsemeyle geri geldi. Bütün mal varlığını senin üstüne geçirdi ve dildoyu alıp gitti. Merkezde bir ev satın aldın ve hayatına devam ediyorsun.(BEKLENMEDİK DİLDO SON)");
                    }
                }
                if (a3 == 3)
                {
                    Console.WriteLine("Said'in labnesine çöktün. Labneyi yerken Said uyandı ve seni gördü. Sinirlenip götünü parmakladı ve sakat kaldın. (PASİF GAY SON)");
                }
                    
            }
            if (a == 4)
            {
                Console.WriteLine("He bi sen zekisin soyunu, spounu, ırzını, şerefini, gelmişini, geçmişini, elini, kolunu, zürriyyetini, içini, dışını, milliyetini, ağzını, yüzünü, götünü, başını, içtiğin içeçeği, yediğin yemeği, doğduğun yeri, yaşadağın şehri, yaşadağın evini, barkını, tahtanı, silgini, gözündeki yaşı, böbreğindeki taşı, alnındaki kaşı, kafandaki başı yetmezse cebindeki bütün bozuklukları tek tek siktiğiminin malı seni.(DALYARAK SON)");
            }




            #endregion

            Console.Read();
        }        
    }
}
