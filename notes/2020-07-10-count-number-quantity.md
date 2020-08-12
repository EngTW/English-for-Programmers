```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 如何命名「數量變數」
時間 Fri Jul 10 14:47:45 2020
```

「英文」是不少人學寫程式的一個關卡，而「命名」又是電腦科學最難的問題之一
。我正在整理幾個最常見的「如何用英文命名程式裡的某個東西？」的問題與答案
，在此與各位分享目前整理好的第一個題目：

* 如何命名「數量變數」？
  * Count / Number / Quantity
  * 什麼時候該用哪個字？該怎麼用？

---
* Google 簡報版: https://bit.ly/38OWoKf
  * Google 簡報原始檔: https://bit.ly/3elcZGT
* Facebook 相簿版: https://bit.ly/3iNsgDO
* GitHub 討論區: https://bit.ly/321ResR

---
首先，可以試試看命名以下變數（文末有參考答案）：

1. 玩家(player)數量
2. 彈藥(ammo)數量
3. 子彈(bullet)質量(mass) （以克(gram)計）
4. 生命值(hit points)

如果這對你來說沒有難度，或許你會有興趣到 GitHub 討論區看看其它我正在整理
的題目: https://bit.ly/321ResR

---
# 命名「數量變數」的方法

1. 辨認變數名詞詞性
   * 不可數名詞
   * 可數生物
   * 可數非生物
2. 對應單字及格式（見後文）
   * 可數生物、可數非生物： Count / Number
   * 不可數名詞、可數非生物： Quantity

---
# 不可數名詞

##  推薦格式

* 不可數名詞 + In + 單位(複數)

  goldInKilograms 黃金（以公斤計）

* 單位(複數) + Of + 不可數名詞

  kilogramsOfGold 黃金（以公斤計）

##  其它格式

* 不可數名詞 + Amount ： goldAmount 黃金數量

* 不可數名詞 + Quantity ： goldQuantity 黃金數量

* amountOf + 不可數名詞 ： amountOfGold 黃金數量

* quantityOf + 不可數名詞 ： quantityOfGold 黃金數量

這些格式無法清楚表達數量單位，其可讀性在科學或金融計算上並不理想，但在其
它情景或許不是問題（例如，遊戲設計）。

---
# 可數生物

##  推薦格式

* 生物(單數) + Count

  studentCount 學生人數

  尤其適合為「用來計數的變數」命名

* numberOf + 生物(複數)

  numberOfEmployees 員工人數

##  常見問題

* 生物(單數) + Number

  在語意上是「號碼」的意思

  studentNumber 學生號碼

* countOf + 生物(複數)

  在語法上通常不會這樣寫

---
# 可數非生物

##  推薦格式

* 非生物(單數) + Count

  bookCount 書本數量

  尤其適合為「用來計數的變數」命名

* 非生物(單數) + Quantity

  bookQuantity 書本數量

  尤其適合用在「貨物」上

* numberOf + 非生物(複數)

  numberOfBooks 書本數量

* quantityOf + 非生物(複數)

  quantityOfBooks 書本數量

  尤其適合用在「貨物」上

##  常見問題

* 非生物(單數) + Number

  在語意上是「號碼」的意思

  accountNumber 帳戶號碼

* countOf + 非生物(複數)

  在語法上通常不會這樣寫

---
# 其它討論

* 有的時候，程式可讀性的確是 *相對地* 沒那麼重要。

  * 滿足需求、解決問題、創造價值最重要。

* 提昇程式可讀性的方法不止一種

  * 要把程式碼上下文脈絡、使用情景、團隊文化、產業領域也納入考量。

---
相對於「寫作風格」（駝峰式大小寫、蛇式／烤肉串式、等等），我想從另一個角
度，聚焦於「學會用英文表達想法」，

  學會用英文提昇程式可讀性。

我很想知道讀者在寫程式時，遇到了怎麼樣的英文表達問題。

我目前有蒐集到一些題目，例如：

* Count / Length / Size,  什麼時候該用哪個字？該怎麼用？
* Copy / Clone / Duplicate
* Sum 與 Total  的差別
* Validate vs. Verify

很歡迎讀者推文（或到 GitHub 討論區 https://bit.ly/321ResR ）提出

* 問題
* 建議
* 感想

謝謝。

---
# 練習題 *參考* 答案

1. numberOfPlayers, playerCount
2. quantityOfAmmo, ammoQuantity
3. bulletMassInGrams
4. hitPoints

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1594363672.A.7D0.html
推 chuegou: 這個有趣 07/10 14:56
推 goodseeyou: 推 07/10 14:57
推 sk6852: 實用 07/10 15:10
推 devilkool: 實用推 07/10 15:14
推 y2468101216: 推 07/10 15:21

謝謝各位的欣賞 :) 如果在程式寫作上有任何與英文表達有關的問題，請讓我知道
，這會是「用英文提昇程式可讀性」很棒的研究題材。

推 vi000246: 我喜歡台式英文 bulletWeight remainLife 07/10 15:31

完全能理解，解決問題優先。

語言能做到優雅當然是好，但最重要的功能還是溝通（人與人的溝通、人與機器的
溝通）。

我開了 https://github.com/EngTW/English-for-Programmers/issues/8  來追蹤
這個題目，謝謝 :)

※ 編輯: AmosYang (136.56.13.184 美國), 07/10/2020 15:56:07
推 jobintan: niceTutorial, it_is_very_useful. 07/10 15:52

XD
※ 編輯: AmosYang (136.56.13.184 美國), 07/10/2020 15:57:50
→ askaleroux: magicNumber // do not erase this 07/10 15:58
→ testPtt: 基本上不用Quantity 太長 07/10 16:06

完全能理解，縮寫、簡寫、更短的字、更簡潔的寫法，只要能解決問題，都是好的
。

我開了 https://github.com/EngTW/English-for-Programmers/issues/7  來追蹤
這個題目，謝謝 :)

推 RedArmy95: 推 07/10 16:15
推 chuegou: #define ZERO 0 07/10 16:31
推 unmolk: 樓上是殺小xddd 07/10 16:52
推 bowin: 推 AmosYang 好文！ 07/10 16:59
推 accessdenied: zero = 0 這個我真的看到！ 還有 True = 1, False = 07/10 17:09
→ accessdenied:  0 07/10 17:09
推 alihue: 推 07/10 17:12
推 sniper2824: 好文 07/10 17:12
推 ben810514: bulletCount 07/10 17:27
→ ben810514: 沒事 是重量以為是數量 07/10 17:28
→ sirius65482: 不管啦 通通用xxxNum 07/10 17:40
→ bheegrl: ammoQty 07/10 17:40

我開了 https://github.com/EngTW/English-for-Programmers/issues/7  來追蹤
「縮寫、簡寫」這個題目；謝謝提供這個題目 :)

推 paulshain04: 很讚欸 推一個 07/10 18:07
推 Rm: amount跑去哪了 07/10 18:09

amount  整理在「不可數名詞」的「其它格式」那段。 :)

amount  本身當主詞時，常用來描述金錢上的「總金額(total amount)」，我開了
https://github.com/EngTW/English-for-Programmers/issues/9 來追蹤這個題目
，謝謝 :)

推 atpx: 好文, 不得不推 07/10 19:02
→ pttano: 我都定arg1，arg2，var1，var2 07/10 19:10
→ pttano: 我都定arg1，arg2，var1，var2 07/10 19:10
推 kokolotl: a1, b1啊～～ 07/10 19:11
→ pttano: 我都定arg1，arg2，var1，var2 07/10 19:12
→ pttano: 我都定arg1，arg2，var1，var2 07/10 19:13
→ pttano: 我都定arg1，arg2，var1，var2 07/10 19:14
推 infixman: 推推 07/10 19:19
推 chuegou: 樓上重複定義編譯器不給過 07/10 19:21
推 dks50217: Cnt 07/10 19:21

我開了 https://github.com/EngTW/English-for-Programmers/issues/7  來追蹤
「縮寫、簡寫」這個題目；謝謝提供這個題目 :)

→ yyc1217: remove delete erase cancel dismiss 07/10 19:24

我開了 https://github.com/EngTW/English-for-Programmers/issues/10 來追蹤
這個題目，謝謝 :)

推 enthos: pn, an, bg, hp \ Forth(Write-only lang.) style. 07/10 19:35

我開了 https://github.com/EngTW/English-for-Programmers/issues/7  來追蹤
「縮寫、簡寫」這個題目；謝謝 :)

推 goldflower: 看過中國人用拼音寫扣 jin_jia_ki_si 07/10 19:46

我開了 https://github.com/EngTW/English-for-Programmers/issues/8  來追蹤
這個題目，謝謝 :)

→ leo5916267: 多查英文字典吧？有時候直接問英文好的人資XD超好笑 07/10 19:57
→ leo5916267: ，寫程式還會問到人資那邊 07/10 19:57
推 gasbomb: 上一份工作看到的 氣死https://i.imgur.com/x9GmljV.jpg 07/10 19:59

我開了 https://github.com/EngTW/English-for-Programmers/issues/8  來追蹤
這個題目，謝謝 :)

推 jason90929: 讚 07/10 20:09
推 Lhmstu: 推推 07/10 21:00
推 negligence: 推 07/10 21:39
推 invidia: 感謝分享 07/10 22:13
→ abc0922001: 感謝分享，命名真的是難題 07/10 22:26
推 jasonwung: 實用推 07/10 22:59
→ labbat: qwertyyuiop 07/10 23:10
推 CaptPlanet: 推 07/10 23:21
推 dces4212: nr_student 07/10 23:28

我開了 https://github.com/EngTW/English-for-Programmers/issues/7  來追蹤
「縮寫、簡寫」這個題目；謝謝 :)

→ OrzOGC: 用拼音真的...還有日文拼音的...冏... 07/10 23:46

我開了 https://github.com/EngTW/English-for-Programmers/issues/8  來追蹤
這個題目，謝謝 :)

推 Dracarys: foo bar baz 07/11 00:10

我開了 https://github.com/EngTW/English-for-Programmers/issues/11 來追蹤
"metasyntactic variable"  這個題目，謝謝 :)

推 Luke3723: 推 07/11 00:21
※ 編輯: AmosYang (136.56.13.184 美國), 07/11/2020 02:40:00

感謝各位的欣賞與提供題目 orz

如果我漏看了題目，請告訴我，謝謝 :)
※ 編輯: AmosYang (136.56.13.184 美國), 07/11/2020 02:44:32
推 Bencrie: nr_ 這個是 Linux kernel 的命名 07/11 02:46

感謝指點 orz

推 richard07250: 先推在看 07/11 03:39
推 Ouranos: Amos 必推!!! 07/11 04:02
※ 編輯: AmosYang (136.56.13.184 美國), 07/11/2020 05:36:24
推 ben4562002: 推 獲益良多 07/11 08:32
推 joy7658x348: 推！命名對新人工程師更是一個問題XD常常會看不懂那 07/11 09:45
→ joy7658x348: 是啥 07/11 09:45
推 NeCool: 推 07/11 09:57
推 coder5566: 推 07/11 11:34
推 believe91326: 實用推 07/11 15:08
推 zxcv860513: 推，很怕看到需要通靈的命名 07/11 16:12

感謝各位的欣賞 :)

如果能想到「很難看懂、需要通靈」的命名案例，請讓我知道；這可以幫助我把這
些資料整理得更完善，謝謝。

在這篇底下推文，或在 GitHub 或 Facebook 留言都可以 :)

* GitHub: https://github.com/EngTW/English-for-Programmers/issues
* Facebook: https://bit.ly/3iNsgDO
※ 編輯: AmosYang (136.56.13.184 美國), 07/12/2020 04:07:11

補上 Google 簡報原始檔: https://bit.ly/3elcZGT
※ 編輯: AmosYang (136.56.13.184 美國), 07/12/2020 12:44:21
推 klandakuei: 推 07/12 22:15
推 visual: 推 07/14 18:55
推 zelt: 推 07/17 10:20
推 a8319: 有趣又實用 07/20 14:00
推 beryah: 推 07/26 00:57

謝謝 :)
※ 編輯: AmosYang (136.56.13.184 美國), 08/08/2020 03:09:46
```
