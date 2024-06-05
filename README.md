Bu proje, C# ve SQLite kullanılarak geliştirilmiş kapsamlı bir uçuş rezervasyon sistemidir. Sistem, uçuş rezervasyonlarını, müşteri bilgilerini ve uçuş programlarını yönetmek için çeşitli işlevler içerir.
________________________________________

Özellikler

•	** Kullanıcı Kaydı ve Giriş:

•	** Yeni kullanıcılar için kayıt olma ve mevcut kullanıcılar için giriş yapma.

•	** Uçuş Arama ve Rezervasyon:

•	** Kullanıcıların mevcut uçuşları arayabilmesi ve rezervasyon yapabilmesi.

•	** Müşteri Bilgilerini Yönetme:

•	** Kullanıcıların profil bilgilerini güncelleyebilmesi.

•	** Uçuş Programlarını Görüntüleme:**

•	** Kullanıcıların tüm uçuş programlarını görüntüleyebilmesi.

•	** Yönetim Paneli:

•	** Yöneticilerin uçuşları ve kullanıcı hesaplarını yönetebilmesi.
________________________________________
MODELS

Location.cs = uçak rezervasyon sisteminde kullanılacak olan konum (lokasyon) bilgilerini tutar. Bir kullanıcı uçuş araması yaptığında, bu model kullanılarak hangi ülkede, hangi şehirde ve hangi havaalanında işlem yapıldığı belirlenebilir. Ayrıca, lokasyonun aktif veya pasif durumda olup olmadığı kontrol edilebilir.

Plane.cs = Bu sınıf, uçaklara ait bilgileri tutar ve veritabanındaki bir tablonun veya bir API'nin döndüreceği uçak verilerini temsil eder. Örneğin, uçuş planlamasında veya rezervasyon işlemlerinde hangi model, marka ve seri numarasına sahip uçağın kullanılacağı, bu uçakta kaç koltuk bulunduğu gibi bilgiler bu model aracılığıyla yönetilebilir.

Reservation.cs = Bu model, uçak rezervasyon sisteminde yapılmış rezervasyonlara ait bilgileri tutar. Örneğin, bir müşteri uçak bileti rezervasyonu yaptığında, bu model kullanılarak rezervasyonun detayları (uçak bilgisi, lokasyon bilgisi, tarih, müşteri bilgileri ve koltuk numarası gibi) saklanabilir ve yönetilebilir. 

DataLocation = Bu sınıf, uçak rezervasyon sisteminde basit bir veri taşıyıcı olarak kullanılır. Örneğin, bir API çağrısından veya bir veritabanı sorgusundan elde edilen ülke, şehir ve havaalanı bilgilerini taşımak ve yönetmek için kullanılabilir. Bu sınıfın basit ve doğrudan bir yapısı vardır, yani herhangi bir iş mantığı içermez; sadece veri saklama ve taşıma işlevi görür.

DbContext = Bu sınıf, Entity Framework Core kullanılarak veritabanı işlemlerini yönetmek için tasarlanmıştır. DBContext sınıfı, projenin veritabanı modelini tanımlar ve bu modele erişim sağlar.. DbSet özellikleri, belirli veritabanı tablolarına erişim sağlar ve 
bu tabloların veri manipülasyonu için kullanılır.
________________________________________

frmLocation = Bu form, uçak rezervasyon sistemindeki lokasyon bilgilerini yönetmek için kullanılır. kullanıcının lokasyon bilgilerini düzenleyebilmesi için gerekli olan tüm işlevleri içerir. Veritabanı bağlantısı üzerinde işlemler gerçekleştirir ve kullanıcının verilerle etkileşimde bulunmasını sağlar.

frmMain= Bu ana form, uygulamanın kullanıcı arayüzünde kullanılacak olan diğer formlara (uçak, lokasyon ve rezervasyon formları gibi) erişimi sağlar.

frmPlane = Bu form, kullanıcı arayüzünde uçak eklemek, güncellemek ve silmek için gerekli işlevleri sağlar. Bu form uygulamanın uçaklarla ilgili verilerini yönetmek için kullanılır. Kullanıcılar, form aracılığıyla uçakları ekleyebilir, güncelleyebilir veya silebilirler. Veritabanı bağlantısı üzerinde işlemler gerçekleştirir ve kullanıcının verilerle etkileşimde bulunmasını sağlar.

frmReservation = Bu form, uygulamanın uçak rezervasyonlarıyla ilgili verilerini yönetmek için kullanılır. Kullanıcılar, form aracılığıyla rezervasyonları ekleyebilir, güncelleyebilir veya silebilirler. Veritabanı bağlantısı üzerinde işlemler gerçekleştirir ve kullanıcının verilerle etkileşimde bulunmasını sağlar. Ayrıca, rezervasyonlu koltukları görsel olarak göstermek için bir düzen sağlar.

