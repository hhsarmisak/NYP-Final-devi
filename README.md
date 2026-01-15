# NYP-Final-devi
İnsan Kaynakları Yönetim Sistemi
Şirketlerin personel yönetim süreçlerini dijitalleştiren, verimliliği artıran ve veri güvenliğini sağlayan kapsamlı bir masaüstü uygulamasıdır. Bu proje, çalışanların işe alımından performans değerlendirmesine, izin yönetiminden maaş takibine kadar tüm İK süreçlerini tek bir merkezden yönetmeyi sağlar.

Proje Özellikleri
Rol Bazlı Giriş Sistemi: Yönetici, İnsan Kaynakları ve Personel olmak üzere 3 farklı yetki seviyesi. Her kullanıcı sadece yetkili olduğu alanlara erişebilir.

Personel Yönetimi: Çalışanların kişisel, iletişim ve departman bilgilerinin kaydedilmesi, listelenmesi ve güncellenmesi.

Departman Yapısı: Şirket içi departmanların dinamik olarak yönetilmesi ve personellerin ilgili departmanlara atanması.

Performans Değerlendirme: Çalışanların dönemsel performanslarının puanlanması ve raporlanması.

Maaş Takibi: Personel maaşlarının, primlerin ve kesintilerin yönetimi.

İzin Yönetimi: Çalışan izin taleplerinin takibi ve onayı.

Modern Arayüz: Kullanıcı dostu, yuvarlak hatlı butonlar ve renk kodlu (Mor/Krem/Yeşil) modern tasarım.

Kullanılan Teknolojiler ve Mimari
Bu proje, sürdürülebilirlik ve temiz kod prensipleri gözetilerek N-Katmanlı Mimari (N-Tier Architecture) yapısında geliştirilmiştir.

Dil: C# (.NET Framework)

Arayüz: Windows Forms (WinForms) - Özel UI Tasarımı

Veritabanı: MySQL

Mimari:

Domain (Varlıklar): Veritabanı tablolarının nesne karşılıkları.

DAL (Data Access Layer): Veritabanı bağlantısı ve CRUD işlemleri.

Service (BLL): İş mantığı ve veri doğrulama kuralları.

Diyagramlar

ER Diyagramı: Veritabanındaki personel, departman, maas, izin ve performans tabloları arasındaki ilişkisel yapı.

Katmanlı Mimari Şeması: UI -> Service -> DAL -> Database akışını gösteren yapı.

<img width="628" height="403" alt="image" src="https://github.com/user-attachments/assets/b035de02-a218-4577-b9e1-32ffb0b7c26b" />

1. Giriş Sayfası (Login)
Sade ve şık bir tasarıma sahip giriş ekranı. Kullanıcı adı ve şifre doğrulaması yapılır, hatalı girişlerde kullanıcı uyarılır. Başarılı girişte kullanıcının rolü (Yönetici/İK/Personel) algılanarak ilgili yetkilerle ana menü açılır.

<img width="720" height="499" alt="image" src="https://github.com/user-attachments/assets/e9723237-6373-4c32-aa0e-95068820531d" />

3. Ana Menü (Dashboard)
Kullanıcının yetkisine göre aktif veya pasif olan modüllerin bulunduğu merkezi kontrol paneli. Modern ikonlar ve yuvarlatılmış butonlarla zenginleştirilmiş bir deneyim sunar.

4. Personel Yönetimi
Tüm çalışanların listelendiği, departmanlarına ve rollerine göre filtrelendiği ekran. Yeni personel ekleme formunda veri doğrulama (boş alan kontrolü vb.) mevcuttur.

5. Performans ve Değerlendirme
Yöneticilerin çalışanlara dönem bazlı puan ve açıklama girebildiği modül. Bu veriler veritabanında saklanarak ileride raporlama için kullanılır.


🛠️ Proje Klasör Yapısı
Domain: Veritabanı nesneleri (Personel.cs, Departman.cs vb.)

DAL (Data Access Layer): Veritabanı ile konuşan sınıflar (PersonelDAO.cs, Baglanti.cs).

Service: İş kurallarının işletildiği katman (PersonelService.cs).

UI (Forms): Kullanıcının gördüğü ekranlar (MainForm, LoginForm, EmployeeForm).

✨ Gelecek Hedefleri
Gelişmiş grafiksel raporlama (Chart entegrasyonu).

Personel resimlerinin veritabanına kaydedilmesi.

Bulut tabanlı veritabanı entegrasyonu.

📞 İletişim
Bu proje Hüseyin Hamza Sarmısak tarafından NYP dersi kapsamında geliştirilmiştir.

Geliştirici: Hüseyin Hamza Sarmısak
E-posta: 132430043@ogr.uludag.edu.tr

Youtube videosu:https://www.youtube.com/watch?v=J0UcDaQcHcI
