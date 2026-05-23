# 🛠️ C# Temel Programlama, Algoritma ve Veri Yönetimi Koleksiyonu

Bu depo, C# programlama dilinde algoritma mantığı, veri doğrulama (validation), nesne yönelimli programlama temelleri ve Windows Forms mimarisi üzerinde gerçekleştirdiğim çalışmaları içermektedir. Projeler, içerdikleri algoritmik yaklaşımlara ve sorumluluk alanlarına göre iki ana başlık altında sınıflandırılmıştır.

---

## 🖥️ 1. Masaüstü Uygulamaları (Windows Forms)

Görsel arayüz (UI) tasarımı, olay tabanlı programlama (Event-Driven Programming) ve asenkron durum yönetimleri içeren projeler:

### 🎮 XOX (Tic-Tac-Toe) Oyunu (`xox`)
- **Algoritmik Altyapı:** Turn-based (sıra tabanlı) oyuncu durum yönetimi (`whichPlayer`). Oyun tahtasındaki 9 hücrenin durumu tamsayı değişkenleri ile simüle edilmiştir.
- **Kazanma Mantığı:** Her buton tetiklenmesinde (`Click Event`) aktif olan `CheckWinner()` metodu; yatay, dikey ve çapraz 8 farklı kombinasyonu doğrusal mantıksal operatörlerle (`&&` ve `||`) kontrol eder.
- **Bellek Yönetimi:** `ResetGame()` metodu ile tüm hücre değişkenleri, buton metinleri ve aktiflik durumları (`Enabled = true`) tek bir fonksiyon çağrısıyla bellekten temizlenerek oyun akışı sıfırlanır.

### 🧮 Gelişmiş Hesap Makinesi (`hesap_makinesi`)
- **Durum Yönetimi (State Management):** Sayı girişleri arayüzde dinamik olarak gösterilirken, arka planda `string` birleştirme (concatenation) mantığıyla `girilenSayi` değişkeninde biriktirilir.
- **Operatör Bayrak Mekanizması:** İşlem butonlarına tıklandığında güncel sayı tamsayıya dönüştürülür ve `islemTuru` değişkenine sayısal bir bayrak (1: Toplama, 2: Çıkarma, 3: Çarpma, 4: Bölme) atanır.
- **Çözümleyici Motor:** Eşittir (`=`) butonuna basıldığında, atanan bayrağa göre `if-else` kontrol blokları çalıştırılarak matematiksel işlem tamamlanır ve sonuç arayüze basılır. `Clear (C)` butonu ile tam bellek temizliği sağlanır.

### 🔢 Armstrong Sayı Doğrulayıcı (`armstrong3`)
- **Matematiksel Algoritma:** Girilen tamsayının basamaklarını `while (sayi2 > 0)` döngüsü içerisinde `sayi2 % 10` mantığıyla tek tek ayırır. Her basamağın küpünü (`kalan * kalan * kalan`) hesaplayıp `toplam` değişkeninde biriktirerek Armstrong sayı teorisini doğrular.
- **Savunmacı Kontrol:** Kullanıcının boş metin kutusuyla butona basması ihtimaline karşı `if (textBox1.Text != "")` doğrulaması eklenerek runtime (çalışma zamanı) hataları önlenmiştir.

---

## 📊 2. Algoritma ve Mantık Alıştırmaları (`AlgorithmicChallenges`)

Veri yapıları, performans optimizasyonları ve matematiksel problem çözme odaklı konsol ve form uygulamaları:

### 📐 Çok Boyutlu Dizi Analizi (`matrix`)
- **Veri Yapısı:** $3 \times 4$ boyutlarında iki boyutlu matris (`int[,] dizi`) mimarisi kullanılmıştır.
- **Performans Optimizasyonu:** İç içe döngüler (`nested loops`) kullanılarak satır toplamları hesaplanırken, eş zamanlı olarak tek bir geçişte dikey sütun toplamları da `sutunToplamlari[j] += dizi[i, j];` algoritmasıyla biriktirilir. Bu yaklaşım zaman karmaşıklığını (Time Complexity) minimize eder.
- **Arayüz Biçimlendirme:** Konsol çıktısında verilerin nizami hizalanması için `PadLeft(8)` metodu kullanılarak profesyonel bir tablo görünümü elde edilmiştir.

### 🛡️ Güvenli Basamak Çarpımı Hesaplayıcı (`carpmaçalışma`)
- **Savunmacı Programlama (Defensive Programming):** Programın çalışma zamanında çökmesini önlemek amacıyla `Convert` yerine `int.TryParse` metodu kullanılmış, geçersiz girdiler filtrelenmiştir.
- **Sınır Durum (Edge Case) Yönetimi:** Sayının negatif olma ihtimaline karşı `Math.Abs` fonksiyonu entegre edilmiştir. Sayının `0` olması durumu döngüye sokulmadan `return;` anahtar kelimesiyle (Early Exit) filtrelenerek performans kazancı sağlanmıştır.
- **Algoritma:** `while(sayi > 0)` döngüsü içerisinde matematiksel mod operatörü (`% 10`) ve tam sayı bölmesi (`/= 10`) kullanılarak sayı basamaklarına ayrıştırılmış ve çarpım sonucu biriktirilmiştir.

### ⏱️ Erken Çıkışlı Asal Sayı Kontrolörü (`asal_çalışma`)
- **Algoritma Yapısı:** Sayının asallık durumunu `while` döngüsü içinde test eder.
- **Döngü Optimizasyonu:** Sayının tam bölündüğü ilk nokta yakalandığı an (`sonuc == 0`), döngü sayacı doğrudan hedef sayıya eşitlenerek (`sayac = x;`) döngüden erken çıkış (Early Exit) sağlanır. Bu sayede gereksiz işlemci yükü engellenir.

### 🔄 Matematiksel Metin Tersine Çevirici (`tersten_az`)
- **Mantıksal Yaklaşım:** Hazır bir `Reverse()` string metodu kullanmak yerine, problemin tamamen sayısal mantıkla çözülmesi hedeflenmiştir.
- **Algoritma:** Sayı döngü içinde 10 tabanına göre parçalanır, elde edilen kalanlar `tersSayi = (tersSayi * 10) + kalan;` formülüyle basamak değerleri sola kaydırılarak matematiksel olarak ters yüz edilir.

### 🔵 Daire Çapı ve Alan Hesaplayıcı (`daire_çapi_bulma`)
- **Modüler Fonksiyon Yönetimi:** Geometrik formüller ($A = \pi \cdot r^2$ ve $Ç = 2 \cdot \pi \cdot r$) kod yapısına entegre edilmiştir. Alan ve çevre hesaplama sorumlulukları farklı olay tetikleyicilerine (`button1_Click` ve `button2_Click`) dağıtılarak kodun okunabilirliği artırılmıştır.

---

## 🛠️ Kullanılan Teknolojiler ve Gereksinimler
- **Programlama Dili:** C#
- **Mimariler:** .NET Core, Windows Forms Desktop Architectures, Console Applications
- **IDE:** Visual Studio 2022
