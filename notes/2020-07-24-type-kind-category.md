```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 如何命名「種類」
時間 Fri Jul 24 13:12:28 2020
```

有時候，我們會依照人事物的性質、特徵做「分組(group) 、標記(tag) 」。

像是：

* 把房間裡的雜物分類成書籍、服飾、器具。
* 把書分類成小說、漫畫、工具書。
* 把小說分類成愛情、歷史、奇幻、科幻。

那麼，該怎麼用英文描述那個「分組的種類、類別、類型」？

# 先說結論： "category" 可說是最萬用的選擇。

這篇文章會深入探討 type / class / category / classification 的語意，希望
能幫助讀者學會用英文提昇程式可讀性。

* Google 簡報 https://bit.ly/2OOSpEs
* Facebook 相簿 https://bit.ly/3ju7sBz
* GitHub 討論 https://bit.ly/321ResR

---
# 如何命名「種類」？

「分組、標記」時，中文多半會用「種、類、型」來表達那「分組的組別」。

例如：

1.  書籍種類 ← 小說、漫畫。
2.  刊物分類 ← 週刊、月刊、年刊
3.  遊戲類型 ← 動作、戰略、模擬
4.  艙等種類 ← 經濟艙、商務艙
5.  血型 ← Ａ、Ｂ、Ｏ、ＡＢ
6.  髮型 ← 長髮、短髮
7.  狗的品種 ← 柴犬、哈士奇

讀者可以試試將以上「種、類、型」等字對應到英文字彙（本文最後有參考答案）
。

如果這對你來說很容易，可以到《程式英文》 GitHub 討論區 https://bit.ly/321ResR
看看有沒有更有趣的題目，或提出你在寫程式時遇到的英文問題；這能幫助我把這
個知識庫整理得更完善。謝謝 :)

---
隨著情景、領域不同，用來表達「種、類、型」的英文字彙也不同。

# 情景

大致而言，「把人事物分組」有三種目的；它們對應的英文字如下：

* 區分、隔離 → type / class
* 歸納、整理 → category / subcategory
* 定義、鑑別 → classification / 領域特有字

# 領域

有些領域有它的特有字，比如：

* 藝術作品（電影、音樂、遊戲） → genre
* 車 → make、 model
* 生物 → 物種(species)、品種(breed)、品系(strain)

本文後面會提到如何探索每個領域的特有字。

---
# 情景：為了「區分、隔離」而分組

例如說：

* 「世界上有 10 種人：懂二進位的人、不懂二進位的人。」

「懂二進位的人」、「不懂二進位的人」都是人，而這裡的語意是想 *區分* 這兩
種人。

在這種情景下，就適合用 type / class 。

## Type

除了「種、類」， type 還可以對應到「型」。

例如：

* 血型(blood type)
* 統計學上的「第一型錯誤(type I error)」、「第二型錯誤(type II error)」

## Class

class 除了「種類」外，另有「級」（階級、品級）的意思。

例如：

* 頭等艙(first class)
* 中產階級(middle class)

---
# 情景：為了「歸納、整理」而分組

相對於「為了『區分、隔離』而分組」，有時候就只是單純列舉「種類、組別」；
例如說：

* 「書店二樓的書大致上有三類：漫畫、小說、畫冊。」

這種情景下就適合用 category ；如果有需要，可以再細分為 subcategory 。

例如：

* 念能力：強化、放出、變化、操作、具現化、特質
* 商品種類
  * 在電商網站上常可看到 Category / Categories  等字。
  * 參考截圖： https://bit.ly/2OTcQ2M

---
# 情景：為了「定義、鑑別」而分組

有的時候需要「嚴謹的分組」；例如說：

* 「汽車駕照有『普通、職業』兩大類，每類再細分為『小型車、大貨車、大客車
  、聯結車』四種。」

這時候就適合用 classification ，或著該領域特有字。

例如：

* 期刊類別：週刊、月刊、季刊、年刊
  * 出刊頻率(publication frequency)
* 獵人階級：無牌、業餘、初級、一星、二星、三星

---
# 那 Sort / Kind 呢？

## Sort

在電腦科學、軟體工程、程式設計的領域裡，因為 sort 更常與「排序」連結在一
起，所以不建議再用 sort 來表種「種類」。

## Kind

kind  可以用在「避免與程式語言中既有的 "type" 混淆」的情形。

例如 .NET 的 `DateTimeKind` 是用來區分一 DateTime 物件是當地時間，或是
UTC 時間。

*如果*  被命名為 DateTimeType， 就容易與 "DateTime type" 混淆。

---
# 探索「領域特有字」

##  參考電商網站

從電商網站的商品目錄、搜尋介面可以學到它們是用哪些字表達「種、類」。

諸如：

* https://store.steampowered.com/ 用 genre  來分類遊戲。
* https://www.youtube.com/audiolibrary/music
  * 用 genre, mood, instrument  （類型、心情、樂器）來分類音樂。
  * 用 category 來分類音效。
* https://www.carmax.com/cars
  * 用 type 來分類車種（運動型休旅車、卡車、轎車、等等）
  * 用 brand / make 來分類品牌
  * 用 model  來分類車系
  * 用 price  來分類售價範圍
  * 用 body style 來分類車型
  * 用 year 來分類製造年份

## 拜 Google

或著，可以這樣拜 Google：

* how to categorize 名詞
* how to classify 名詞

例如 "how to categorize wine" （如何分類酒）傳回的第一個結果：

* "Classification of wine"
  * https://en.wikipedia.org/wiki/Classification_of_wine

可以進一步找到更多的關鍵字：

* place of origin / appellation 產地
* vinification methods and style  釀酒方法
* sweetness 甜度
* vintage 年份

另一個例子， "how to classify steak"  （如何分類牛排）傳回的第一個結果：

* Understanding Cuts and Grades of Steak
  * https://www.thespruceeats.com/steak-grades-and-cuts-331671

可以從該文章找到更多關鍵字，像是牛排的等級(grade)、牛肉的部位(cut) 。

---
# 到底什麼時候該用哪一個字？

"category" 可說是最萬用的選擇。

依情景不同，以下是一些參考案例：

* 卡爾達肖夫指數（Kardashev Scale）
  * 「第幾型（type）文明」
* 薩菲爾-辛普森颶風風力等級（Saffir–Simpson hurricane wind scale）
  * 「第幾級（category）颶風」
* 船級（Ship class）
  * 「船級（class）」
  * 「船種（type）」
  * 福特級航空母艦（Ford-class aircraft carriers）
* 牛排熟度（Doneness）
  * Degree of Doneness
  * Level of Cooking

如果有不確定的情形，歡迎到《程式英文》 GitHub 討論區 https://bit.ly/321ResR
提問、討論。

---
# 「種、類、型」 vs.  「組、標籤、屬性」

前面提到的「種、類、型」英文字彙適合用來與「人」溝通。

例如：

* 電商網站介面 → 與客戶、消費者溝通
* 程式碼 → 與開發團隊成員溝通

實務上，程式設計師考量「演算法、資料結構」時，多少會需要把「種、類、型」
更進一步抽象化成「組、標籤、屬性」。

這裡列舉這「抽象化」過程可能會有幫助的英文單字：

* 組 → Group
* 標籤 → Tag
* 屬性 → Attribute / Property

---
題外話： 「 Attribute 與 Property 有什麼不同？」

坦白說，我也不知道 XD

我開了 https://github.com/EngTW/English-for-Programmers/issues/25 來追蹤
這個問題。

---
# 結語

如果程式用字能接近美式英文當然是好，但不需要給自己太大的壓力，因為每個人
都是從零開始學起 :)

這一系列文件的目的是想幫助讀者縮小中英文之間語感的落差。

這篇關於「種類」的文章，是從讀者提問得到的靈感，我自己也學到了很多東西。

若你在程式寫作上有遇到「英文表達」的問題，歡迎在這篇文章下留言，或到以下
網站提問討論。

* GitHub 討論區 https://bit.ly/321ResR
* Facebook 相簿 https://bit.ly/3ju7sBz
* Twitter  討論 https://bit.ly/2CYKgdZ

這可以幫助我把這系列文件整理得更完善，謝謝 :)

---
# 其它資訊

* Google 簡報 https://bit.ly/2OOSpEs

##  *參考*  答案

1. category
2. classification, publicationFrequency
3. genre
4. class
5. type
6. style
7. breed

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1595567563.A.CCF.html
推 tbpfs: 趕快推~以免被人家知道不懂 07/24 13:17

XD

在寫這篇文章前，其實我對這幾個字的語意差別是一知半解。

是從網友提問才發現，這幾個字背後也有它的學問。 :)
※ 編輯: AmosYang (136.56.13.184 美國), 07/24/2020 13:22:53
推 alohac: 念能力還蠻恰當的 嘻嘻 07/24 13:51
→ testPtt: 我偏要用zhonglei 07/24 14:01

XD

推 yyhsiu: 推，然後樓上我笑了 07/24 15:17
推 yoche2000: 推念能力 07/24 15:30

講到念能力，

> * 期刊類別：週刊、月刊、季刊、年刊
>   * 出刊頻率(publication frequency)

「期刊類別」除了「週刊、月刊、季刊、年刊」，應該再加個「火鳳、冨樫」。 XD

→ roccqqck: species如何 07/24 18:26

根據字典，看來 "species" 適合用在科學方面，例如

* 生物物種
* 化學、物理上的原子、分子、離子、粒子的種類

推 kevin979: 推，最近公司要統一命名規範，心好累～ 07/24 18:45

能理解 :)

如果遇到英文相關的問題，歡迎來討論 (或 Facebook, Twitter  私訊也可以) :)

* GitHub 討論區 https://bit.ly/321ResR
* Facebook 相簿 https://bit.ly/3ju7sBz
* Twitter  討論 https://bit.ly/2CYKgdZ
※ 編輯: AmosYang (136.56.13.184 美國), 07/24/2020 19:57:55
推 WestMelon: 優文推 07/24 19:44

謝謝 :)

推 handsomeburg: 但type / class很大比例是保留字 07/24 19:48

十分同意。

* 有些語言允許使用保留字，例如 C# 可以在保留字前加上 "@", 就可以當一般
  identifier  使用；例如 @object
* 有些語言是 case-sensitive,  大寫的 Class  不會被視為 "class"  保留字
* 最後還有一個方法，就是組合字，例如 ShipClass  ，來避開保留字
※ 編輯: AmosYang (136.56.13.184 美國), 07/24/2020 20:06:55
推 jasonwung: 推 07/24 20:56
推 CaptPlanet: 讚讚讚 07/24 22:48

謝謝 :)

推 brianhsu: 另一種是故意換個方式拼，用 clazz 也滿常看到的。 07/25 09:20

同意，感謝補充 :)
※ 編輯: AmosYang (136.56.13.184 美國), 07/25/2020 11:18:00
推 ian90911: 感謝分享 07/25 14:04
推 sk6852: 推！感謝分享 07/25 15:19
推 qaz0101: 推 07/25 17:09

謝謝 :)

推 CoNsTaR: Kind 在 type system 裡面也有意思啊 07/26 14:13

的確，你說的對。

我把原文

> kind  可以用在「避免與電腦科學的 "type system"  的 "type" 混淆」的情形。

改成了

> kind  可以用在「避免與程式語言中既有的 "type" 混淆」的情形。

這樣應該比較不會造成更多誤會？

推 mybluesky: 好文推 07/26 16:53

謝謝 :)
※ 編輯: AmosYang (136.56.13.184 美國), 07/26/2020 20:52:28
```
