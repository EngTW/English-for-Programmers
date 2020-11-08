```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 刷 LeetCode 練習命名
時間 Sun Nov  8 12:25:54 2020
```

# 刷 LeetCode 練習命名

過去幾個月，《程式英文》把焦點放在「分享知識」；例如，變數名稱樣板、單字
使用情景、等等。對學習者來可說是「輸入」的動作。

這次試個不同的方向，做了個實驗，把焦點換到「演練技巧」，希望能幫助學習者
改善輸入與輸出的平衡。

* Google 文件 https://bit.ly/2GIyLtk
* GitHub 討論區 https://bit.ly/321ResR

# 先說結論

* 實驗內容：用 C# 刷 20 題「解題率最高、 Easy 等級」的 LeetCode
  * 題目列表： https://github.com/EngTW/English-for-Programmers/issues/69
* 所有 20 題 LeetCode 英文題目（含提示）總共約 2841 字。
  * 其中 2434 字 (86%) 包含在「高中英文 7000 字」內。
  * 可還原成約 394 個單字原型；例如， am, are, is 的單字原型為 be 。
    * 其中 285 個單字原型 (72%) 包含在「高中英文 7000 字」內。
* 所有 20 題 LeetCode 解答內「自訂變數」用了約 119 英文字。
  * 其中 105 字 (88%) 包含在「高中英文 7000 字」內。
  * 可還原成約 44 個單字原型。
    * 其中 36 個單字原型 (81%) 包含在「高中英文 7000 字」內。

以下是一些觀察與心得。

# 堆疊（ stack ）字

在英文語法中，可以把多個字「堆疊（ stack ）」起來來表達意思，例如，程式
設計師熟知的 API: Application Programming Interface 。

這樣的語法也可以應用在命名變數上，但要小心拿捏資訊量與複雜度的平衡；例如：

* 在有 1 個字的時候，例如， Name, 只有 1 種讀法，沒有問題。
* 在有 2 個字的時候，例如， ManagerName, 仍只有 1 種讀法，沒有問題。
* 在有 3 個字的時候，例如， StoreManagerName, 就有 2 種可能的讀法要去辨別：
  * StoreManager Name
  * Store ManagerName
* 在有 4 個字的時候，例如， DollarStoreManagerName, 就有 (4-1)! = 6 種可
  能的讀法要去辨別。
* 在有 5 個字的時候，例如， CentralDollarStoreManagerName, 就有
  (5-1)! = 24 種可能的讀法要去辨別。

每多一個字的確會加入新的資訊，但也會提高閱讀的困難度（複雜度超過工作記憶
區的容量，使得資訊變成了雜訊）。

我個人經驗是「用 3 個字以下的變數名稱」，如果要用到超過 3 個字，或許可以
想想否是能用其它方法（程式碼架構、型別、註解、規格書、等等）來提供讀者理
解程式碼所需的上下文脈絡。

# 是什麼（ what ）、為什麼（ why ）

以下這個案例很有趣：

* https://github.com/EngTW/English-for-Programmers/issues/89
  * https://leetcode.com/problems/sum-of-all-odd-length-subarrays/

程式碼本身是在實作從題目要求推導出來的解答算式。

在這個案例中，我發現要描述「這個變數『是什麼』」並不難，難的是讓讀者了解
「為什麼要有這個變數」。

最後我選擇用註解的方式提示推導解答算式的方向，讀者需要先了解解答算式，程
式碼才會比較好懂。

相對之下，其它案例的變數的名稱與實際使用情形多半可以說明該變數「是什麼」
及「為什麼」。

# 英文語法資料

## 位數

案例： https://github.com/EngTW/English-for-Programmers/issues/79

* 個位： ones place 或 units place
* 個位數： ones digit 或 units digit
* 十位： tens place
* 十位數： tens digit
* 十分位： tenths place
* 十分位數： tenths digit

參考資料

* https://en.wikipedia.org/wiki/Numerical_digit#Computation_of_place_values

## 上限、下限、包含、不含

案例： https://github.com/EngTW/English-for-Programmers/issues/88

* 上限： upper bound 或 majorant
* 下限： lower bound 或 minorant
* 包含： inclusive
* 不含： exclusive
* 參考資料
  * https://en.wikipedia.org/wiki/Upper_and_lower_bounds
  * https://www.lexico.com/en/definition/inclusive
  * https://www.lexico.com/en/definition/exclusive

# 結語

* 因為是第一次進行這樣的實驗，所以選了 LeetCode 是 Easy 級解題率最高的
  20 題。
  * 從簡單題目開始，容易掌控問題複雜度，適合新手學習者入門。
  * 對進階學習者來說， LeetCode 的程式架構變化少，學習效果可能有限。
  * 題目定義明確，有共通的討論基礎。
  * 就現今軟體業求職面試文化來看，學習者投入「刷 LeetCode 」的成本容易回收。
  * LeetCode 題目是以英文寫成，也是練習英文的機會。
* 解答的首項要求是正確，再來是可讀性，最後是效能（時間、空間）、程式碼語
  法的精練度。

讀者如果有興趣的話，可以 code review 一下這裡列出來的 20 題 LeetCode 解
答，尤其是其「命名可讀性」；或著，對 LeetCode 題目或解答中的任何英文用字
、語文解讀有疑問的，也歡迎提出來討論。

* https://github.com/EngTW/English-for-Programmers/issues/69

在此感謝所有參與討論的網友 :)

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1604809565.A.3F9.html
```
