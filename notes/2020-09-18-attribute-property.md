```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 「屬性」該用哪個字？
時間 Fri Sep 18 11:43:53 2020
```

本週主題

* 「屬性」該用哪個字？
  * Attribute, Property 有什麼不一樣？

結論：沒有一定的標準。

* 在哲理上
  * 「由外部因素賦予此物件的屬性」，所謂 extrinsic property
    * 稱為 property, 也可稱為 attribute
  * 「此物件內在本質的屬性」，所謂 intrinsic property
    * 稱為 property
* 在語源上
  * attribute 偏向「賦予」；「由外部因素賦予此物件的屬性」
  * property 偏向「本質」；「此物件內在本質的屬性」
* 在程式實作上，沒有一定的標準。
  * 下面列舉了 C#, HTML, DOM 的例子。

---
* GitHub 討論 https://bit.ly/321ResR
* Google 簡報 https://bit.ly/32DAoAD

---
# Attribute, Property 有什麼不一樣？

* 在哲理上
  * 「由外部因素賦予此物件的屬性」，所謂 extrinsic property
    * 稱為 property, 也可稱為 attribute
  * 「此物件內在本質的屬性」，所謂 intrinsic property
    * 稱為 property
* 在語源上
  * attribute 偏向「賦予」；「由外部因素賦予此物件的屬性」
  * property 偏向「本質」；「此物件內在本質的屬性」

## Attribute

* 語意：外部(extrinsic) / 關係(relational) 屬性
  * 由「與其它物件的關係」賦予此物件的屬性
  * 例如，一個物件的「重量」；由此物件所處的重力場賦予的屬性
* 語源： 14 世紀後期，動詞「賦予、指派」，名詞「對某人的評價」
* 在程式上
  * 可表達物件、元素的屬性
  * 常用來表達「屬性的屬性」

## Property

* 語意
  * 內部(intrinsic) 屬性
    * 物件本質上的屬性
    * 例如，一個物件的「質量」
  * 也可以代表 外部(extrinsic) / 關係(relational) 屬性
* 語源： 1300 年代，本質、特性
* 在程式上
  * 可表達物件、元素的屬性

# Attribute, Property 該用哪個字？

在程式實作上，不同語言、框架、環境對於「物件屬性」這個觀念的心智模型多少
有出入，並沒有一定的標準。

我個人偏好 C# 的風格。

## 以 C# 為例

* 在「為東西加註資料(metadata)」的情景下，用 `Attribute`
  * 例如， `DebuggerBrowsableAttribute`

* 而「類別的屬性」，稱為 `Property`
  * 例如， `String.Length`

## 以 HTML / DOM 為例

HTML (attribute) / DOM (property) 則是用了不同的字來表達「東西的屬性」。

引用 https://stackoverflow.com/a/53924373 的例子：

```
<input id="the-input" type="text" value="Name:">
```

* 假設使用者在此輸入欄位填上了 "foo"

* 接下來以 `<input>` 代表此 HTML 元素(element)

* 接下來以 `theInput` 代表此 DOM 物件

* 執行 theInput.value 會得到 "foo"
  * value 是 theInput 這個 DOM 物件的 property (屬性)

* 執行 theInput.getAttribute('value') 會得到 "Name:"
  * `getAttribute()` 是 theInput 這個 DOM 物件的方法
  * value 是 `<input>` 這個 HTML 元素的 attribute (屬性)

## 參考資料

* https://en.wikipedia.org/wiki/Attribute_(computing)
* https://en.wikipedia.org/wiki/Property_(philosophy)#Intrinsic_and_extrinsic_properties
* https://stackoverflow.com/a/53924373
* https://www.etymonline.com/word/attribute
* https://www.etymonline.com/word/property
* https://www.lexico.com/en/definition/attribute
* https://www.lexico.com/en/definition/property

感謝參與 https://github.com/EngTW/English-for-Programmers/issues/25 討論
的網友。

---
這週比較忙，只研究了一個題目。 XD

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1600400643.A.D04.html
※ 編輯: AmosYang (136.56.13.184 美國), 09/18/2020 11:44:41
※ 編輯: AmosYang (136.56.13.184 美國), 09/18/2020 11:46:46
→ yoche2000: 推 09/18 12:06
推 hans1461: 推 09/18 12:08

謝謝 :)

→ chatnoir: vue跟react都用props傳參數給child耶, 我要去發PR XDDD 09/18 12:17

我不熟 vue, react 及其架構理念；能不能談談你是為什麼想去發什麼樣的 PR ？ :)
※ 編輯: AmosYang (136.56.13.184 美國), 09/18/2020 12:25:38
→ krazy1101: React 的 props 官方文件表示 properties 的縮寫，但 09/18 12:29
→ krazy1101: 行為比較像是從外部傳值進入元件，剛好跟你寫的定義相 09/18 12:29
→ krazy1101: 反 09/18 12:29

謝謝你的說明 :)

這讓我想到 C# 語言中，類別(class)的 "property" 也是支援 setter/getter 。

或許這要看這些語言、框架的設計者有沒有留下紀錄它當初思路、考量的文件，才
能知道它為什麼要這樣設計、選用特定的字。

推 easterday: 我也覺得attribute->內在,property->外在 09/18 12:40
→ easterday: 這樣的用法比較多 09/18 12:41

(延續上面的討論)

或許可以這樣想：

* 在哲理思維層級，

  * 東西有質量(mass)；質量是東西的 內部(intrinsic) 屬性(property)
    * 東西存在，就有質量；質量不受外部因素影響

  * 東西有重量(weight)；重量是東西的 外部(extrinsic) 屬性(attribute)
    * 東西有重量，是因為「這個東西」與「這環境的重力場」的關係
    * 東西的重量受外部因素「重力場」的影響

* 在程式實作層級，可能是寫成這樣：
```

```C#
class Thing
{
    public double MassInGrams { get; set; }
    public double WeightInGrams { get; set; }
}
```

```
從 C# 語言層級來看， `MassInGrams`, `WeightInGrams` 都是 `Thing` 這個
類別(class)的屬性(property)。
※ 編輯: AmosYang (136.56.13.184 美國), 09/18/2020 13:32:10
推 virdust2003: 認同這篇 09/18 13:18

謝謝你的欣賞 :)

---
(延續上面的討論)

我修改了上面的原文

# 舊

* 語意：內部(intrinsic) 屬性
  * 物件本質上的屬性
  * 例如，一個物件的「質量」

# 新

* 語意
  * 內部(intrinsic) 屬性
    * 物件本質上的屬性
    * 例如，一個物件的「質量」
  * 也可以代表 外部(extrinsic) / 關係(relational) 屬性


# 參考資料

* https://en.wikipedia.org/wiki/Property_(philosophy)#Intrinsic_and_extrinsic_properties

> An intrinsic property is a property that an object or a thing has of
> itself, independently of other things, including its context.

> An extrinsic (or relational) property is a property that depends on a
> thing's relationship with other things.

> The latter is sometimes also called an attribute, since the value of
> that property is given to the object via its relation with another
> object.
※ 編輯: AmosYang (136.56.13.184 美國), 09/18/2020 13:49:45
推 chatnoir: 感謝k大幫我解釋 ~  我只是開玩笑的 09/18 14:19

我覺得那是很有意思的題目，也讓我發現了我的文章最原始的版本寫得不夠清楚；
希望推文中的後續討論、補充說明有幫助 :)
※ 編輯: AmosYang (136.56.13.184 美國), 09/18/2020 14:37:57
→ ChungLi5566: 對岸是翻成固有屬性跟自定義屬性 09/18 14:47

謝謝補充資訊 :)

推 DCTmaybe: 請問有argument,parameter系列嗎？ 09/18 15:08

有，可以參考

* https://www.ptt.cc/bbs/Soft_Job/M.1597982849.A.9A7.html
* 或 Google 簡報 https://bit.ly/3l161ey 第 17 頁

---
這系列文章的列表： https://github.com/EngTW/English-for-Programmers

也有列出每個文章的主要關鍵字，可以用 CTRL-F 找你想查的字。

推 CoNsTaR: argument, parameter 問題出在中文沒有適合的詞來翻 argu 09/18 17:07
→ CoNsTaR: ment，所以只好都叫參數吧... 09/18 17:07
→ Jockey66666: argument(引數) parameter(參數) 蠻多這樣翻的吧 09/18 20:08

是的，我查到的也是這樣翻：

* 方法、函數宣告的是參數 (parameter)
* 傳入方法、函數的是引數 (argument)

推 LERICAL: 推 09/18 20:38

謝謝 :)

---
文章編輯說明；希望這樣子能更清楚 :)

# 舊：「哲理、語意」混在一起

* 在哲理、語意上
  * attribute 偏向「由外部因素賦予此物件的屬性」
  * property 偏向「此物件內在本質的屬性」

# 新：「哲理、語意」分開來說

* 在哲理上
  * 「由外部因素賦予此物件的屬性」，所謂 extrinsic property
    * 稱為 property, 也可稱為 attribute
  * 「此物件內在本質的屬性」，所謂 intrinsic property
    * 稱為 property
* 在語源上
  * attribute 偏向「賦予」；「由外部因素賦予此物件的屬性」
  * property 偏向「本質」；「此物件內在本質的屬性」
※ 編輯: AmosYang (136.56.13.184 美國), 09/18/2020 21:25:21
```
