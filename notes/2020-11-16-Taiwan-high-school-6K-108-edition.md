```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 高中6K字-108版
時間 Tue Nov 17 08:03:03 2020
```

# 高中6K字-108版

大學入學考試中心「選才電子報」第 312 期（ 2020-08-17 ）談論了新版的
《高中英文參考詞彙表》，內有單字、詞性、級別，並提供 PDF 版下載；我把它
清理了一下，整理出 JSON 版及 Google Sheets 版，方便應用。

* Google Sheets 版： https://bit.ly/2ULo0tL
* JSON 版： https://bit.ly/2ILggFo
  * JSON schema 可參考程式碼 https://bit.ly/3kwIVek 裡的
    `Common/WordInformation.cs` 。

---

* 這篇文的 Google Docs 版： https://bit.ly/35C8AhB
* GitHub 討論區 https://bit.ly/321ResR

## 大學入學考試中心的版權聲明

來自大學入學考試中心釋出的 PDF 檔的首頁：

> 著作權屬財團法人大學入學考試中心基金會所有，僅供非營利目的使用，轉載請
> 註明出處。若作為營利目的使用，應事前經由財團法人大學入學考試中心基金會
> 書面同意授權。

## 來源連結

* 大學入學考試中心「選才電子報」第 312 期（ 2020-08-17 ）： https://www.ceec.edu.tw/xcepaper/cont?xsmsid=0J066588036013658199&qunit=0J066616104134302815&sid=0K227548677326460907

* 《高中英文參考詞彙表》 PDF 原檔： https://www.ceec.edu.tw/files/file_pool/1/0k213571061045122620/%e9%ab%98%e4%b8%ad%e8%8b%b1%e6%96%87%e5%8f%83%e8%80%83%e8%a9%9e%e5%bd%99%e8%a1%a8%28111%e5%ad%b8%e5%b9%b4%e5%ba%a6%e8%b5%b7%e9%81%a9%e7%94%a8%29.pdf

## 編輯方針

* PDF 原檔列出了 6012 條項目，是以字義為主；例如，
  * railroad, railway （鐵路）是同一個項目。
  * medium 當形容詞（中等）時是一個項目，當名詞（媒介）時是另一個項目。
* 我整理的版本以拼字為主，有 6170 條項目；例如，
  * railroad, railway 算兩個項目。
  * medium 的形容詞、名詞算同一個項目。

---

* PDF 原檔最後附錄有列出一些名詞；例如，
  * 基數、序數、詞性
  * 日、月、季
  * 國家、大陸、海洋、宗教
* 我整理的版本不包含該附錄

# 程式英文

我寫了個小程式（ https://bit.ly/3kwIVek ）來整理這個字表；若只計算我宣告
的型別、方法、變數（不算程式語言關鍵字、內建框架/函式庫用字），這個小程
式一共用了約 32 個英文單字，其中 27 (84%) 個有包含在此
《高中英文參考詞彙表》字表內。

剩下 5 個單字是：

* delimiter
* enumerator
* JSON
* optimal
* predicate

---

我使用的命名大致上都是以 2, 3 個單字組成的堆疊字。

比較明顯的例外有：

* knownWordDataCount // 已知 WordData 數量
* knownWordInfoCount // 已知 WordInfo 數量
* RawDataReaderExtensions // 原始 資料 讀取器 延伸物（複數）
* WordDataReaderExtensions  // 單字 資料 讀取器 延伸物（複數）
* 以及 `CompileData/WordDataReaderExtensions.cs` 裡的方法名稱。

有興趣的話，可以 code review 一下這份程式碼，看看在型別、方法、變數命名
上是否「好懂」。

有任何想法、疑問，都歡迎提出來討論 :)

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1605571388.A.0D0.html
推 Csongs: 可以貼高中板，會有比較多使用心得（？） 11/17 08:27

請問，「高中板」是指 SENIORHIGH 板嗎？ :)
※ 編輯: AmosYang (136.56.13.184 美國), 11/17/2020 08:43:43
→ Csongs: 對喔 ,他們應該要學測了XD 11/17 08:44

了解，謝謝你的建議。 :)

我去跟該板板務確認一下這篇文的東西適不適合貼過去。
※ 編輯: AmosYang (136.56.13.184 美國), 11/17/2020 09:26:22
```
