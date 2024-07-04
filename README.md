# Solid

SOLID, nesne yönelimli programlamada yazılım tasarımı prensiplerini tanımlayan bir akronimdir. Bu prensipler, yazılımın daha esnek, ölçeklenebilir ve bakımının daha kolay olmasını sağlar. SOLID prensipleri şunlardır:

S - Single Responsibility Principle (SRP): Tek Sorumluluk Prensibi

Bir sınıf, sadece bir iş yapmalıdır ve bu iş için tek bir neden olmalıdır. Başka bir deyişle, bir sınıfın yalnızca bir tür sorumluluğu olmalıdır.
O - Open/Closed Principle (OCP): Açık/Kapalı Prensibi

Bir yazılım varlığı (sınıf, modül, fonksiyon vb.), genişletilmeye açık olmalı, ancak değiştirmeye kapalı olmalıdır. Yeni işlevler eklenirken mevcut kod değiştirilmemelidir.
L - Liskov Substitution Principle (LSP): Liskov Yerine Geçme Prensibi

Türemiş sınıflar, temel sınıfların yerine kullanılabilmelidir. Bu, türemiş sınıfların, temel sınıfın beklenen davranışını bozmadan onun yerine geçebilmesi anlamına gelir.
I - Interface Segregation Principle (ISP): Arayüz Ayrım Prensibi

Müşteriler, kullanmadıkları arayüzlere bağımlı kalmamalıdır. Büyük ve geniş kapsamlı arayüzler yerine, daha küçük ve spesifik arayüzler tercih edilmelidir.
D - Dependency Inversion Principle (DIP): Bağımlılıkların Ters Çevrilmesi Prensibi

Yüksek seviyeli modüller (iş mantığını içeren modüller), düşük seviyeli modüllere (detayları içeren modüller) bağımlı olmamalıdır. Her iki tür modül de soyutlamalara bağımlı olmalıdır. Soyutlamalar detaylara bağımlı olmamalıdır, detaylar soyutlamalara bağımlı olmalıdır.
Bu prensipler, yazılım geliştirme sürecinde daha modüler, anlaşılır ve bakım yapılabilir kod yazmaya yardımcı olur.
