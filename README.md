 Aslı'm Butik Konsol Otomasyonu (C#)

Bu proje, C# dilinde temel konsol uygulamaları geliştirme becerilerini pekiştirmek amacıyla yazılmış, basit bir mağaza/butik yönetim simülasyonudur. Uygulama, temel finansal işlemleri ve kullanıcı girişi yönetimi gibi kritik programlama prensiplerini göstermektedir.

---

Proje Hedefleri ve Özellikleri

Proje, aşağıdaki temel C# konularını uygulamalı olarak göstermektedir:

 1. Güvenli Girdi Yönetimi (Hata Yakalama)

`Try-Catch` Kullanımı:** Kullanıcının sayısal veri girmesi gereken alanlarda (`ürün no`, `adet`, `para yatırma tutarı`), hatalı (metinsel) giriş yapılması durumunda uygulamanın çökmesi engellenmiştir. Bu, uygulamanın kararlılığını artırır.
* **Akış Kontrolü:** Hatalı veya geçersiz ürün numarası girişlerinden sonra (`continue` komutuyla) kullanıcıya tekrar deneme fırsatı verilir; program akışı kesintiye uğramaz.

2. Finansal Mantık ve Veri Yönetimi

* **Bakiye Güncelleme:** Para yatırma işleminde, **`+=` operatörü** kullanılarak mevcut bakiyenin üzerine doğru bir şekilde ekleme yapılır.
* **Komisyon Hesaplama:** Yatırılan tutardan %2 oranında komisyon kesintisi yapılmaktadır.
* **Dizi (Array) Yapısı:** Ürün isimleri ve fiyatları, programatik yönetimi kolaylaştırmak için paralel dizilerde tutulmuştur.

 3. Kullanıcı Deneyimi ve Navigasyon

* **Menü Yönetimi (`while` Döngüsü):** Ana menü, kullanıcı çıkış yapana kadar sürekli olarak erişilebilir durumdadır.
* **Geri Dönüş Mekanizması:** Alt menülerden (`Satın Alma`) ana menüye, `return` komutu kullanılarak anında ve temiz bir şekilde dönüş sağlanmıştır.

---

Teknik Yapı

* **Programlama Dili:** C#
* **Geliştirme Ortamı:** .NET Console Uygulaması
* **Kullanılan Temel C# Elemanları:** Static Metotlar, Diziler, Döngüler (`while`, `for`), Karar Yapıları (`if/else`), Hata Yönetimi (`try-catch`).

---

## Kullanım Talimatları

1.  Projenin kaynak kodunu indirin.
2.  Visual Studio'da açın.
3.  Uygulamayı çalıştırın ve konsol ekranındaki yönergeleri takip edin.

---

*Bu proje, öğrenme ve C# dilindeki temel yapıları pekiştirme amaçlı oluşturulmuştur.*
