```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 如何命名「檢查」功能２
時間 Fri Aug 21 12:07:06 2020
```

自上週發布「如何命名『檢查』功能」後，收到許多回饋和討論，特別是 Verify,
Validate 之間的比較。

這週將深入比較 verify / verification vs. validate / validation 的案例；附
帶討論 argument vs. parameter 的差別。

* Google 簡報 https://bit.ly/3l161ey
* GitHub 討論 https://bit.ly/321ResR

* 如何命名『檢查』功能１
  * Google 簡報 https://bit.ly/31UiEPK
  * PTT 文章 https://bit.ly/3ixdi3M

---
# 「驗證」： Validate vs. Verify 案例比較

validate 與 verify 的語意非常接近，在非正式的情景多半可以互換使用。

這裡，我們將檢視以下案例來試著鑑別 validate 與 verify 在語意上細微的差異：

* IEEE 1012: Verification and Validation
  * IEEE 標準 1012 對 verification 及 validation 的定義

* validation, verification 在各種情景下的語意、出現頻率

感謝參與 https://github.com/EngTW/English-for-Programmers/issues/45 討論
的網友。

---
# IEEE 1012: Verification and Validation

## Verification

「開發過程可分成多個階段；
  每個階段收尾時，驗證『成品是否滿足此階段的目標？』」

也就是驗證「有沒有把東西做對？」，而「對」的定義由該開發階段的「輸入」來
判斷。

例如說：

* 需求Ｒ：「做出整數加法器」

* 設計階段：輸入需求Ｒ，輸出規格書Ｓ
  * 規格書Ｓ會定義整數輸入格式、加法的演算法、如何處理溢位、等等
  * 就「設計階段」而言， verification 會驗證「規格書Ｓ是否能滿足需求Ｒ？」

* 實作階段：輸入規格書Ｓ，輸出程式Ｐ
  * 程式Ｐ會定義程式碼的細節、執行加法、處理例外情形、等等
  * 就「實作階段」而言， verification 會驗證「程式Ｐ是否能滿足規格書Ｓ？」

## Validation

「開發過程可分成多個階段；
  每個階段收尾時，驗證『成品是否滿足此階段的目的？』」

也就是驗證「有沒有做對的東西？」，而「對」的定義由更高層次的整體「目的」
來判斷。

例如說：

* 需求Ｒ：「做出整數加法器」
  * validation 驗證內容包括「整體來看，整數加法器真的是最適當的解決方案嗎？」

* 設計階段：輸入Ｒ，輸出規格書Ｓ
  * validation 驗證內容包括「規格書Ｓ開出來的執行條件、技術限制合理嗎？」

* 實作階段：輸入Ｓ，輸出程式Ｐ
  * validation 驗證內容包括「程式Ｐ的使用體驗如何？是否真正解決了使用者的
    問題？」

## 參考資料

* https://en.wikipedia.org/wiki/Verification_and_validation
* https://en.wikipedia.org/wiki/Software_verification_and_validation

---
# 「驗證」： Validate vs. Verify 語意 / 出現頻率

我們挑選了以下字樣來比較 validation, verification 在各種情景下的語意、出
現頻率。

這些字樣包括程式設計相關字（例如： code, HTML, password ），也有些日常用
語的字彙（例如： age, identity, signature ）。

* age 年齡
* code 程式碼
* data 資料
* email 電子郵件
* file 檔案
* form 表格
* HTML 超文本標記語言
* identity 身分
* password 密碼
* signature 簽名
* user 使用者

## 採樣方式

* 把以上字樣以 "XXX validation" / "XXX verification" 的形式餵給 Google
* 記錄 Google 傳回的搜尋結果數量
* 歸納 Google 搜尋結果前 3 頁中，該詞的使用情景

---
# 驗證 年齡 (age)

## Validate / Validation

Google 搜尋結果數量： 89k

* 驗證「生物年齡鑑定方法」的準確度
* （極少案例）驗證輸入字串是否為合理的年齡數值
* （極少案例）驗證是否合乎組織、法律規定

## Verify / Verification

Google 搜尋結果數量： 16600k

* 驗證年齡是否合乎組織、法律規定

---
# 驗證 程式碼 (code)

## Validate / Validation

Google 搜尋結果數量： 595k

* 驗證程式碼、資料是否符合資料格式、語言規格
  * JSON, XML, HTML
  * 郵遞區號、信用卡號碼

## Verify / Verification

Google 搜尋結果數量： 524k

* 驗證程式碼實作方法、行為、執行結果是否符合功能規格書

---
# 驗證 資料 (data)

## Validate / Validation

Google 搜尋結果數量： 4430k

* 驗證資料的品質
  * 正確性、準確性、一致性、安全性、隱私性、等等
  * 格式是否「乾淨」、適合機器處理

## Verify / Verification

Google 搜尋結果數量： 1390k

* 驗證資料遷移 (migration) 後的正確性

## 參考資料

* https://en.wikipedia.org/wiki/Data_validation
* https://en.wikipedia.org/wiki/Data_verification

---
# 驗證 email

## Validate / Validation

Google 搜尋結果數量： 928k

* 驗證 email 地址的格式
* 驗證 email 是否有效（參考 verification ）

## Verify / Verification

Google 搜尋結果數量： 11200k

* 驗證 email 是否能確實投遞
* 是否會被各家 ISP 的垃圾信過濾機制攔截
  * 網域名稱過濾機制、等等

---
# 驗證 檔案 (file)

## Validate / Validation

Google 搜尋結果數量： 324k

* 驗證檔案格式是否符合規格
  * PDF, CSV, HTML, JSON, XML, 等等

## Verify / Verification

Google 搜尋結果數量： 152k

* 驗證檔案內容是否一致
* 驗證檔案內容是否完整 (checksum)
* 驗證檔案來源真偽（數位簽證）

## 參考資料

* https://en.wikipedia.org/wiki/File_verification

---
# 驗證 表格 (form)

## Validate / Validation

Google 搜尋結果數量： 2250k

* 驗證表格資料是否符合規格、是否滿足商業需求
  * 必要資訊
  * 日期格式
  * 信用卡號碼格式
  * 電話號碼格式
  * …

## Verify / Verification

Google 搜尋結果數量： 54.2k

* 與 validate / validation 相似

---
# 驗證 HTML

## Validate / Validation

Google 搜尋結果數量： 947k

* 驗證 HTML 資料是否符合規格

## Verify / Verification

Google 搜尋結果數量： 15k

* 以上傳含有特定內容的 HTML 檔案來驗證網站所有權

---
# 驗證 身分 (identity)

## Validate / Validation

Google 搜尋結果數量： 93k

* 驗證身分資料是否符合規格
  * 住址；是否真的有這個地址
  * 電話；是否真的有這支電話
  * …
* 驗證身分資料是否真實（參考 verification ）

## Verify / Verification

Google 搜尋結果數量： 4510k

* 驗證身分資料是否真實、是否真的能連結到一特定、真實存在的人身上

---
# 驗證 密碼 (password)

## Validate / Validation

Google 搜尋結果數量： 423k

* 驗證密碼是否符合規格
  * 英文大小寫、數字、符號……
* 驗證密碼是否正確（參考 verification ）

## Verify / Verification

Google 搜尋結果數量： 226k

* 驗證密碼是否正確

---
# 驗證 簽名 (signature)

## Validate / Validation

Google 搜尋結果數量： 144k

* 說明「由簽名賦與文件法律上的效力」這件事
* 驗證簽名格式、流程、形式是否正確
  * 能否滿足「由簽名賦與文件法律上的效力」的條件
  * 例如，簽名時有沒有見證人

## Verify / Verification

Google 搜尋結果數量： 2820k

* 驗證簽名真偽
  * 是否真的是當事人的手跡

---
# 驗證 使用者 (user)

## Validate / Validation

Google 搜尋結果數量： 242k

* 跟使用者驗證產品功能性、可用性

## Verify / Verification

Google 搜尋結果數量： 1610k

* 驗證使用者（帳號）狀態
  * 是否為真人
  * 使用者帳號帳號信用是否良好

---
# 「驗證」： Validate vs. Verify 該用哪個？

這兩個字的語意有重疊，在口語上也常交換著用；如果實在不確定，通常可以退一
步用 "check" ，表達「檢查」的意圖。

## Validate 「資料本身是否『有效 (valid) 』」？

* 資料是否符合形式規格 / 是否在合理範圍內，例如：
  * 視地區、文化而定，日期有一定的表示格式
  * 年齡不可是負數
  * 電子郵件地址必須是 [email protected] 的格式

* 資料是否完整、準確 / 是否與現實一致，例如：
  * 地址是否完整
  * 生日日期是否真的存在
    * 例如， 2019-02-29 這個日期的格式正確，但事實上不存在

* （在程式設計以外的情景）過程是否合乎規定程序 / 是否符合整體目的，例如：
  * 一份法律文件要有效，除了當事人親筆簽名，可能還需要見證或公證
  * "user validation": 產品的設計是否能確實解決使用者的問題

## Validate / Verify 「資料、系統是否符合『預期的正確條件、狀態』？」

* 年齡是否符合組織、法律規定
* 「起始日」是否在「終止日」之前
* 生日日期是否有正式文件背書
* 法律文件上的簽名筆跡是否為真
  * 是否為見證人 / 公證人認同

---
# 引數 Argument 參數 Parameter 的差別

從 Google 可以找到前人留下的答案：

* 方法、函數宣告的 是 參數 (parameter)
* 傳入方法、函數的 是 引數 (argument)

例如：

```
function foo(parameter) { … }
foo(argument)
```

一篇 "Kt. Academy" 的文章也點出，可以把相似的概念應用在類別(type)上，例如：

```
class Bar<TypeParameter> …
val baz: Bar<TypeArgument> …
```

那麼，為什麼參數是參數、引數是引數？

我們可以從語源學找到線索：

* argument 是從 1300 年代的「根據、證據；推論」而來，帶有「『可從其推導出
  別的觀念』的觀念」的意思。

* parameter 在 1920 - 1950 年代逐漸開始含有「幫助定義系統特性的可測量因素」
  的意思。

一篇 MDSN 文章提供了很有趣的理解方式：

> You can think of the parameter as a parking space and the argument as
> an automobile. Just as different automobiles can park in a parking
> space at different times, the calling code can pass a different
> argument to the same parameter every time that it calls the procedure.

「你可以把參數(parameter)想成停車位(parking space)，把引數(argument)想成
汽車(automobile)。就像不同的汽車在不同的時間可樣停在同一個停車位上，程式
碼每次呼叫函式的時候，可以傳送給函式參數不同的引數。」

## 參考資料

* https://softwareengineering.stackexchange.com/questions/186293/why-are-actual-parameters-called-arguments
* https://blog.kotlin-academy.com/programmer-dictionary-parameter-vs-argument-type-parameter-vs-type-argument-b965d2cc6929
* https://www.etymonline.com/word/parameter
* https://www.etymonline.com/word/argument
* https://stackoverflow.com/questions/1788923/parameter-vs-argument/1788926#comment43458658_1788923
* https://docs.microsoft.com/en-us/dotnet/visual-basic/programming-guide/language-features/procedures/differences-between-parameters-and-arguments

感謝在 https://github.com/EngTW/English-for-Programmers/issues/31 參與討
論的網友。

---
# 結語

如果有軟體工程、程式設計相關的英文問題，歡迎推文提問，或著到《程式英文》
GitHub  討論區留言。

* https://bit.ly/321ResR
* https://github.com/EngTW/English-for-Programmers/issues

大家集思廣益、切磋砥礪，增強英文語感，提昇程式可讀性。 :)

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1597982849.A.9A7.html
推 sniper2824: 先推 08/21 12:16
推 jobintan: nice. 08/21 12:20
推 jerryshadow: 先推 08/21 12:27
推 javy0521: 推 08/21 12:50
推 hans1461: 推 08/21 13:26
推 summerleaves: 推 08/21 14:36
推 BlazarArc: 推 08/21 15:18
推 TWkobe: 謝謝 很實用 08/21 15:53
推 minesos520: push 08/21 16:30

謝謝 :)

推 ayugioh2003: 推 參數引數那段好懂又好記 08/21 21:45

謝謝你的欣賞 :)

推 Ouranos: 推推! 08/21 22:19
推 LIN810116: 推 08/22 04:37
推 sksksk0487: 推 08/22 13:38

謝謝 :)

推 Csongs: 所以verify包含validation 08/22 13:54

我是這樣看，先重新檢視字典的定義：

---
## validate

> check or prove the validity or accuracy of (something).

檢查、證明某事物的 有效性 或 準確性

> demonstrate or support the truth or value of.

展示、支持某人事物的確實性、 (精神上的) 價值

> make or declare legally valid.

宣告、認可某事物 在法律上的有效性

> recognize or affirm the validity or worth of (a person or their
> feelings or opinions); cause (a person) to feel valued or worthwhile.

認可、確性某人 (或它的感受、意見) 的 有效性、 (精神上的) 價值

## verify

> make sure or demonstrate that (something) is true, accurate, or justified.

確認、展示某事物為真、準確、合理

> LAW
> swear to or support (a statement) by affidavit.

法律上，以宣誓為某主張背書

---
把這兩個字最主要的解釋並排在一起看，可以看出為什麼那麼難分辨

* validate
  * 檢查、證明某事物的 有效性(validity) 或 準確性
  * validity
    * > the quality of being logically or factually sound; soundness or
      > cogency.
    * 邏輯上、事實上 合理明確一致 ，讓人信服
    * > the state of being legally or officially binding or acceptable.
    * 在法律上 或 正式地 有效/被接受
* verify
  * 確認、展示某事物為真、準確、合理

也就是說，隨著上下文脈絡對「有效性、準確性、真實性、合理性」的解讀的改變
，在 口語 上，這兩個字多半可以互換著用。

(有點事，先離開，等等再回來寫完)

※ 編輯: AmosYang (136.56.13.184 美國), 08/22/2020 21:27:14
※ 編輯: AmosYang (136.56.13.184 美國), 08/22/2020 21:58:41

回到原題

> 所以verify包含validation

與其說「包含」，我會這樣想：

* 如果你選擇把「此資料是否有效」與「此資料是否滿足預期的正確狀態」分開來
  看，那麼，

  * `bool ValidateAge(string age)` 可以做「判斷 age 資料是否有效」；例如
    ， "-3", "foobar" 會是「無效的年齡資料」。

  * `bool VerifyAge(int age)` 可以做「判斷是否符合『對年齡的規定』」；例如
    12 (歲) 就不符合「成人 18 歲的規定」。

* 相對的，如果在你的邏輯模型中你認為「『大於 18 的數字』才是
  有效(valid)的 + 正確的 + 合理的」，也是可以用一個 `ValidateAge()`
  或 `VerifyAge()` 就一次檢查完。

  或著，寫成 `CheckAge()` 也可以，大多數人應該還是能知道你的意圖是「檢查
  age 是否符合你的邏輯模型的要求。
※ 編輯: AmosYang (136.56.13.184 美國), 08/23/2020 13:54:00
推 Csongs: 年齡舉例 蠻清楚的 謝謝 08/24 09:41

不客氣 :)
※ 編輯: AmosYang (136.56.13.184 美國), 08/29/2020 06:30:00
```
