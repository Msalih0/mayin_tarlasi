# 💣 Mayın Tarlası (Minesweeper) - C# Windows Forms

Bu proje, C# ve .NET Windows Forms kullanılarak geliştirilmiş klasik **Mayın Tarlası (Minesweeper)** masaüstü oyunudur.

---

## 🚀 Özellikler

- **10x10 Izgara & 10 Mayın**: Oyun alanı dinamik olarak oluşturulur.
- **Sağ Tık ile Bayraklama (`🚩`)**: Şüphelendiğiniz karelere sağ tıklayarak bayrak koyabilir veya kaldırabilirsiniz.
- **Otomatik Zincirleme Açılma (Flood Fill)**: Etrafında hiç mayın olmayan (0) boş bir kareye tıklandığında komşu kareler otomatik olarak açılır.
- **Renkli Komşu Sayıları**: Karelerin etrafındaki mayın sayıları orijinal klasiğe uygun renklerle gösterilir (1=Mavi, 2=Yeşil, 3=Kırmızı vb.).
- **Kalan Mayın Sayacı**: Ekranda anlık olarak kaç adet mayın kaldığını takip edebilirsiniz.
- **Yeniden Başlat Butonu (`😊`)**: Gülen yüz butonuna tıklayarak istediğiniz an yeni bir oyun başlatabilirsiniz.

---

## 🛠️ Kullanılan Teknolojiler

- **Programlama Dili**: C# (.NET 10)
- **Arayüz Framework**: Windows Forms (WinForms)
- **Geliştirme Ortamı**: Visual Studio 2022 / 2026

---

## 📂 Proje Yapısı

- `Form1.cs`: Oyunun ana mantığı, buton dizilimi, tıklama olayları ve oyun durumları.
- `Cell.cs`: Hücre verilerini (satır, sütun, mayın, bayrak, buton referansı) tutan nesne modeli.
- `Program.cs`: Uygulamanın giriş noktası.

---

## 🎮 Nasıl Oynanır?

1. Projeyi Visual Studio ile açın.
2. `F5` tuşuna basarak oyunu çalıştırın.
3. **Sol Tık**: Kareyi açar. Mayına basarsanız oyun biter!
4. **Sağ Tık**: Kareye bayrak (`🚩`) koyar.
5. Tüm güvenli kareleri açtığınızda oyunu kazanırsınız! 🎉
