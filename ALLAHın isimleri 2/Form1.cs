using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ALLAHın_isimleri_2
{
    public partial class Form1 : Form
    {


        public Form1()
        {
            InitializeComponent();
        }

        private void bttnGr_Click(object sender, EventArgs e)
        {
            string isim = Convert.ToString(txtBxIsim.Text);
            if (isim == "ALLAH")
                MessageBox.Show("Her ismin vasfını ihtiva eden öz adı. Kendinden başka ilah bulunmayan tek ALLAH. Bu ism-i şerif, Cenâb-ı Hakk'ın has ismidir. Bu itibarla diğer isimlerin ifade ettiği bütün güzel vasıfları ve İlâhî sıfatları içine alır. Diğer isimler ise, yalnız kendi mânalarına delâlet ederler. Bu bakımdan ALLAH isminin yerini hiçbir isim tutamaz. Bu isim, ALLAH'tan başkasına mecazen de verilemez.", "ALLAH");
            else if (isim == "EL- ADL")
                MessageBox.Show("Mutlak adil, yerli yerinde yapan.", "EL- ADL");
            else if (isim == "EL- AFÜVV")
                MessageBox.Show("Affı çok olan, günahları mağfiret eden.", "EL- AFÜVV");
            else if (isim == "EL- ÂHİR")
                MessageBox.Show("Ebedi olan, varlığının sonu olmayan.", "EL- ÂHİR");
            else if (isim == "EL- ALÎM")
                MessageBox.Show("Gizli açık, geçmiş, gelecek, her şeyi, ezeli ve ebedi ilmi ile en mükemmel bilen.", "EL- ALÎM");
            else if (isim == "EL- ALİYY")
                MessageBox.Show("Yüceler yücesi, çok yüce olan.", "EL- ALİYY");
            else if (isim == "EL- AZÎM")
                MessageBox.Show("Büyüklükte benzeri yok. Pek yüce olan.", "EL- AZÎM");
            else if (isim == "EL- AZÎZ")
                MessageBox.Show("İzzet sahibi, her şeye galip olan, karşı gelinemeyen.", "EL- AZÎZ");
            else if (isim == "EL- BÂİS")
                MessageBox.Show("Mahşerde ölüleri dirilten, peygamber gönderen.", "EL- BÂİS");
            else if (isim == "EL- BÂKÎ")
                MessageBox.Show("Varlığının sonu olmayan, ebedi olan.", "EL- BÂKÎ");
            else if (isim == "EL- BÂRİ")
                MessageBox.Show("Her şeyi kusursuz ve mütenasip yaratan.", "EL- BÂRİ");
            else if (isim == "EL- BÂSIT")
                MessageBox.Show("Dilediğinin rızkını genişleten, ruhları veren.", "EL- BÂSIT");
            else if (isim == "EL- BASÎR")
                MessageBox.Show("Gizli açık, her şeyi en iyi gören.", "EL- BASÎR");
            else if (isim == "EL- BÂTIN")
                MessageBox.Show("Aklın tasavvurundan gizli olan.", "EL- BÂTIN");
            else if (isim == "EL- BEDÎ")
                MessageBox.Show("Misalsiz, örneksiz harikalar yaratan (eşi ve benzeri olmayan).", "EL- BEDÎ");
            else if (isim == "EL- BERR")
                MessageBox.Show("İyilik ve ihsanı bol olan.", "EL- BERR");
            else if (isim == "EL- CÂMİ")
                MessageBox.Show("İki zıttı bir arada bulunduran. Kıyamette her mahlûkatı bir araya toplayan.", "EL- CÂMİ");
            else if (isim == "EL- CEBBÂR")
                MessageBox.Show("Azamet ve kudret sahibi. Dilediğini yapan ve yaptıran. Hükmüne karşı gelinemeyen.", "EL- CEBBÂR");
            else if (isim == "EL- CELÎL")
                MessageBox.Show("Celal ve azamet sahibi olan.", "EL- CELÎL");
            else if (isim == "ED- DÂRR")
                MessageBox.Show("Elem, zarar verenleri yaratan.", "ED- DÂRR");
            else if (isim == "EL- EVVEL")
                MessageBox.Show("Ezeli olan, varlığının başlangıcı olmayan.", "EL- EVVEL");
            else if (isim == "EL- FETTÂH")
                MessageBox.Show("Her türlü sıkıntıları gideren.", "EL- FETTÂH");
            else if (isim == "EL- GAFFÂR")
                MessageBox.Show("Günahları örten ve çok mağfiret eden. Dilediğini günah işlemekten koruyan.", "EL- GAFFÂR");
            else if (isim == "EL- GAFÛR")
                MessageBox.Show("Affı, mağfireti bol olan.", "EL- GAFÛR");
            else if (isim == "EL- GANİYY")
                MessageBox.Show("İhtiyaçsız, muhtaç olmayan, her şey kendisine muhtaç olan.", "EL- GANİYY");
            else if (isim == "EL- HABÎR")
                MessageBox.Show("Her şeyden haberdar. Her şeyin gizli taraflarından haberi olan.", "EL- HABÎR");
            else if (isim == "EL- HÂDÎ")
                MessageBox.Show("Hidayet veren.", "EL- HÂDÎ");
            else if (isim == "EL- HÂFID")
                MessageBox.Show("Kâfir ve facirleri alçaltan.", "EL- HÂFID");
            else if (isim == "EL- HAFÎZ")
                MessageBox.Show("Her şeyi koruyucu olan.", "EL- HAFÎZ");
            else if (isim == "EL- HAK")
                MessageBox.Show("Varlığı hiç değişmeden duran. Var olan, hakkı ortaya çıkaran.", "EL- HAK");
            else if (isim == "EL- HAKEM")
                MessageBox.Show("Mutlak hakim, hakkı bâtıldan ayıran. Hikmet sahibi olan.", "EL- HAKEM");
            else if (isim == "EL- HAKÎM")
                MessageBox.Show("Her işi hikmetli, her şeyi hikmetle yaratan.", "EL- HAKÎM");
            else if (isim == "EL- HÂLIK")
                MessageBox.Show("Yaratan, yoktan var eden. Varlıkların geçireceği halleri takdir eden.", "EL- HÂLIK");
            else if (isim == "EL- HALÎM")
                MessageBox.Show("Cezada, acele etmeyen, yumuşak davranan, hilm sahibi olan.", "EL- HALÎM");
            else if (isim == "EL- HAMÎD")
                MessageBox.Show("Her türlü hamd ve senaya layık olan.", "EL- HAMÎD");
            else if (isim == "EL- HASÎB")
                MessageBox.Show("Kulların hesabını en iyi gören.", "EL- HASÎB");
            else if (isim == "EL- HAYY")
                MessageBox.Show("Ezeli ve ebedi bir hayat ile diri olan.", "EL- HAYY");
            else if (isim == "EL- KÂBID")
                MessageBox.Show("Dilediğinin rızkını daraltan, ruhları alan.", "EL- KÂBID");
            else if (isim == "EL- KÂDİR")
                MessageBox.Show("Dilediğini dilediği gibi yaratmaya muktedir olan.", "EL- KÂDİR");
            else if (isim == "EL- KAHHÂR")
                MessageBox.Show("Her istediğini yapacak güçte olan, galip ve hâkim olan.", "EL- KAHHÂR");
            else if (isim == "EL- KAVİYY")
                MessageBox.Show("Kudreti en üstün ve hiç azalmaz olan.", "EL- KAVİYY");
            else if (isim == "EL- KAYYÛM")
                MessageBox.Show("Mahlukları varlıkta durduran, zatı ile kaim olan.", "EL- KAYYÛM");
            else if (isim == "EL- KEBÎR")
                MessageBox.Show("Büyüklükte benzeri yok, pek büyük olan.", "EL- KEBÎR");
            else if (isim == "EL- KERÎM")
                MessageBox.Show("Keremi, lütuf ve ihsânı bol, karşılıksız veren, çok ikram eden.", "EL- KERÎM");
            else if (isim == "EL- KUDDÛS")
                MessageBox.Show("Her noksanlıktan uzak ve her türlü takdîse lâyık olan.", "EL- KUDDÛS");
            else if (isim == "EL- LATÎF")
                MessageBox.Show("Her şeye vakıf, lütuf ve ihsan sahibi olan.", "EL- LATÎF");
            else if (isim == "EL- MÂCİD")
                MessageBox.Show("Kadri ve şânı büyük, keremi, ihsanı bol olan.", "EL- MÂCİD");
            else if (isim == "MÂLİK-ÜL MÜLK")
                MessageBox.Show("Mülkün, her varlığın sahibi olan.", "MÂLİK-ÜL MÜLK");
            else if (isim == "EL- MÂNİ")
                MessageBox.Show("Dilemediği şeye mani olan, engelleyen.", "EL- MÂNİ");
            else if (isim == "EL- MECÎD")
                MessageBox.Show("Nimeti, ihsanı sonsuz, şerefi çok üstün, her türlü övgüye layık bulunan.", "EL- MECÎD");
            else if (isim == "EL- MELİK")
                MessageBox.Show("Mülkün, kâinatın sahibi, mülk ve saltanatı devamlı olan.", "EL- MELİK");
            else if (isim == "EL- METÎN")
                MessageBox.Show("Kuvvet ve kudret menbaı, pek güçlü olan.", "EL- METÎN");
            else if (isim == "EL- MU'IZ")
                MessageBox.Show("Dilediğini aziz eden.", "EL- MU'IZ");
            else if (isim == "EL- MUAHHİR")
                MessageBox.Show("Dilediğini alçaltan, sona, geriye bırakan.", "EL- MUAHHİR");
            else if (isim == "EL- MUCÎB")
                MessageBox.Show("Duaları, istekleri kabul eden.", "EL- MUCÎB");
            else if (isim == "EL- MUGNÎ")
                MessageBox.Show("Müstağni kılan. İhtiyaç gideren, zengin eden.", "EL- MUGNÎ");
            else if (isim == "EL- MUHSÎ")
                MessageBox.Show("Yarattığı ve yaratacağı bütün varlıkların sayısını bilen.", "EL- MUHSÎ");
            else if (isim == "EL- MUHYÎ")
                MessageBox.Show("İhya eden, yarattıklarına can veren.", "EL- MUHYÎ");
            else if (isim == "EL- MUÎD")
                MessageBox.Show("Yarattıklarını yok edip, sonra tekrar diriltecek olan.", "EL- MUÎD");
            else if (isim == "EL- MUKADDİM")
                MessageBox.Show("Dilediğini yükselten, öne geçiren, öne alan.", "EL- MUKADDİM");
            else if (isim == "EL- MUKÎT")
                MessageBox.Show("Rızıkları yaratan.", "EL- MUKÎT");
            else if (isim == "EL- MUKSİT")
                MessageBox.Show("Mazlumların hakkını alan, adaletle hükmeden, her işi birbirine uygun yapan.", "EL- MUKSİT");
            else if (isim == "EL- MUKTEDİR")
                MessageBox.Show("Dilediği gibi tasarruf eden, her şeyi kolayca yaratan, kudret sahibi olan.", "EL- MUKTEDİR");
            else if (isim == "EL- MUSAVVİR")
                MessageBox.Show("Varlıklara şekil veren ve onları birbirinden farklı özellikte yaratan.", "EL- MUSAVVİR");
            else if (isim == "EL- MÜ'MİN")
                MessageBox.Show("Güven veren, emin kılan, koruyan, iman nurunu veren.", "EL- MÜ'MİN");
            else if (isim == "EL- MÜBDİ")
                MessageBox.Show("Maddesiz, örneksiz yaratan.", "EL- MÜBDİ");
            else if (isim == "EL- MÜHEYMİN")
                MessageBox.Show("Her şeyi görüp gözeten, her varlığın yaptıklarından haberdar olan.", "EL- MÜHEYMİN");
            else if (isim == "EL- MÜMÎT")
                MessageBox.Show("Her canlıya ölümü tattıran.", "EL- MÜMÎT");
            else if (isim == "EL- MÜNTEKIM")
                MessageBox.Show("Asilerin, zalimlerin cezasını veren.", "EL- MÜNTEKIM");
            else if (isim == "EL- MÜTEÂLÎ")
                MessageBox.Show("Son derece yüce olan.", "EL- MÜTEÂLÎ");
            else if (isim == "EL- MÜTEKEBBİR")
                MessageBox.Show("Büyüklükte eşi, benzeri yok olan.", "EL- MÜTEKEBBİR");
            else if (isim == "EL- MÜZİL")
                MessageBox.Show("Dilediğini zillete düşüren, hor ve hakir eden.", "EL- MÜZİL");
            else if (isim == "EN- NÂFİ")
                MessageBox.Show("Fayda veren şeyleri yaratan.", "EN- NÂFİ");
            else if (isim == "EN- NÛR")
                MessageBox.Show("Âlemleri nurlandıran, dilediğine nur veren.", "EN- NÛR");
            else if (isim == "ER- RÂFİ")
                MessageBox.Show("Şeref verip yükselten.", "ER- RÂFİ");
            else if (isim == "ER- RAHÎM")
                MessageBox.Show("Ahirette, sadece müminlere acıyan, merhamet eden.", "ER- RAHÎM");
            else if (isim == "ER- RAHMÂN")
                MessageBox.Show("Dünyada bütün mahlûkata merhamet eden, şefkat gösteren, ihsan eden.", "ER- RAHMÂN");
            else if (isim == "ER- RAKÎB")
                MessageBox.Show("Her varlığı, her işi her an gözeten. Bütün işleri murakabesi altında bulunduran.", "ER- RAKÎB");
            else if (isim == "ER- RAÛF")
                MessageBox.Show("Çok merhametli, pek şefkatli olan.", "ER- RAÛF");
            else if (isim == "ER- RAZZÂK")
                MessageBox.Show("Her varlığın rızkını veren ve ihtiyacını karşılayan.", "ER- RAZZÂK");
            else if (isim == "ER- REŞÎD")
                MessageBox.Show("İrşada muhtaç olmayan, doğru yolu gösteren.", "ER- REŞÎD");
            else if (isim == "ES- SABÛR")
                MessageBox.Show("Ceza vermede, acele etmeyen.", "ES- SABÛR");
            else if (isim == "ES- SAMED")
                MessageBox.Show("Hiçbir şeye ihtiyacı olmayan, herkesin muhtaç olduğu merci olan.", "ES- SAMED");
            else if (isim == "ES- SELÂM")
                MessageBox.Show("Her türlü tehlikelerden selamete çıkaran. Cennetteki bahtiyar kullarına selâm eden.", "ES- SELÂM");
            else if (isim == "ES- SEMİ")
                MessageBox.Show("Her şeyi en iyi işiten, duaları kabul eden.", "ES- SEMİ");
            else if (isim == "EŞ- ŞEHÎD")
                MessageBox.Show("Zamansız, mekansız hiçbir yerde olmayarak her zaman her yerde hazır ve nazır olan.", "EŞ- ŞEHÎD");
            else if (isim == "EŞ- ŞEKÛR")
                MessageBox.Show("Az amele, çok sevap veren.", "EŞ- ŞEKÛR");
            else if (isim == "ET- TEVVÂB")
                MessageBox.Show("Tevbeleri kabul edip, günahları bağışlayan.", "ET- TEVVÂB");
            else if (isim == "EL- VÂCİD")
                MessageBox.Show("Kendisinden hiçbir şey gizli kalmayan, hiçbir şeye muhtaç olmayan.", "EL- VÂCİD");
            else if (isim == "EL- VÂHİD")
                MessageBox.Show("Zat, sıfat ve fiillerinde benzeri ve ortağı olmayan, tek olan.", "EL- VÂHİD");
            else if (isim == "EL- VÂLÎ")
                MessageBox.Show("Bütün kâinatı idare eden, onların işlerini yoluna koyan.", "EL- VÂLÎ");
            else if (isim == "EL- VÂRİS")
                MessageBox.Show("Her şeyin asıl sahibi olan.", "EL- VÂRİS");
            else if (isim == "EL- VÂSİ")
                MessageBox.Show("Rahmet ve kudret sahibi, ilmi ile her şeyi ihata eden.", "EL- VÂSİ");
            else if (isim == "EL- VEDÛD")
                MessageBox.Show("İyiliği seven, iyilik edene ihsan eden. Sevgiye layık olan.", "EL- VEDÛD");
            else if (isim == "EL- VEHHÂB")
                MessageBox.Show("Karşılıksız nimetler veren, çok fazla ihsan eden.", "EL- VEHHÂB");
            else if (isim == "EL- VEKÎL")
                MessageBox.Show("Kulların işlerini bitiren. Kendisine tevekkül edenlerin işlerini en iyi neticeye ulaştıran.", "EL- VEKÎL");
            else if (isim == "EL- VELİYY")
                MessageBox.Show("Müslümanların dostu, onları sevip yardım eden.", "EL- VELİYY");
            else if (isim == "EZ- ZÂHİR")
                MessageBox.Show("Yarattıkları ile varlığı açık, aşikâr olan, kesin delillerle bilinen.", "EZ- ZÂHİR");
            else if (isim == "ZÜL-CELÂLİ VEL İKRÂM")
                MessageBox.Show("Celal, azamet, şeref, kemal ve ikram sahibi olan.", "ZÜL-CELÂLİ VEL İKRÂM");
            else
                MessageBox.Show("Mânasını görmek istediğiniz ismin harflerini uygulamada gördüğünüz biçimiyle doğru olarak yazınız!", "Uyarı");
        }

        private void bttnKpt_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }


    }
}