```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][英文] 如何命名「刪除」功能
時間 Fri Jul 31 18:08:38 2020
```

「刪除(delete)」是資料處理 CRUD 四大基本項目之一。

這篇文章收錄了幾個與「刪除」有關的程式設計常用字，以及回答讀者相關問題。

* 如何命名「刪除」功能？
  * Clear / Empty / Delete / Remove
  * 有什麼不一樣？

* Google 簡報 https://bit.ly/2XazA2P
* Facebook 相簿 https://bit.ly/2EsPmj9
* GitHub 討論 https://bit.ly/321ResR

# 先說結論

* 在實作後端時，「清除資料容器所有內容物」，使用 clear 。
* 在設計前端時，「清除容器內容物」，使用 clear 、 empty 都可以。

* 在實作後端時，「（從容器）移除物件」，使用 remove 。
* 「刪除物件」，使用 delete 、 remove 都可以。

---
請試試看將以下「刪除、清除」等詞對應到英文。（本文末有參考答案）

1.  清除文字欄
2.  清空購物車
3.  刪除文字欄中第三行字
4.  移除購物車中第三項貨品

如果這對你來說很容易，可以到《程式英文》 GitHub 討論區 https://bit.ly/321ResR
看看有沒有更有趣的題目，或提出你在寫程式時遇到的英文問題；這能幫助我把這
個知識庫整理得更完善。謝謝 :)

---
# 從有到無

用來表達「刪除」動作的字可略分為兩大類：

* 清除「容器、區域、空間」的內容物
  * clear, empty
* 消滅或移除物件
  * delete, remove

這篇文章將會探討以上兩組動詞，以及回答讀者提問：

* clear vs. clean
* delete vs. erase
* cancel vs. dismiss

---
# 清除容器內容物： Clear vs. Empty

* clear 意指「清除某區域中的（障礙）物件」。

  例如，影劇中醫生電擊急救病人時會大喊 "Clear!" 來要求其它人「清場、讓開
  、離遠一點」。

* empty 意指「清空某容器的內容物」。

  例如，電影《瞞天過海：13王牌》中 Al Pacino 演的角色大吼
  "Everyone in this room!  Empty your pockets!  Now!"
  「房間裡的每個人！掏空清出你口袋裡的東西來！現在馬上！」

易言之，作為動詞，

* clear 偏向於「清場」；「場」可以是實體區域，或著是資料容器。

* empty 強調「清空（實體）容器的內容物」
  * 例如「口袋」、電商網站的「購物車」

## clear  的應用實例

* .NET 與 Java 採用 clear 作為「清空容器」 [1] 的方法動詞。
* C++ Standard Library 採用 clear 作為「清空容器」 [7] 的方法動詞。
* 《微軟 PowerShell 動詞表》 [2] 推薦使用 clear 作為「清空容器」的動詞。

## empty  的應用實例

* .NET 採用 empty 作為「取得空的容器、字串、 Guid 、等等」 [3][9][10]
  的方法動詞、成員名字。
* C++ Standard Library 採用 empty 作為「測試此容器是否為空的」 [6] 函式名字。

---
在實作後端時，我推薦使用 clear 來表達「清空資料容器」的動作。

在設計前端時，例如，電商網站、 webmail 介面， clear 與 empty  都可以用來
表達「清空購物車」、「清空垃圾筒」的動作，而 empty 會比 clear 更能強調「
清空」這個動作。

---
# 消滅或移除物件： Delete vs. Remove

* delete 意指「刪除」，把東西從存在變成消滅。

* remove 意指「移除」，也可以表達「刪除」。

## delete 的應用實例

* Facebook 刪除文章
* Twitter 刪除文章
* HTTP 動詞之一
* C++ 銷毀物件（釋放記憶體）
* Windows 刪除檔案
* SQL 刪除資料
* .NET 與 Java 用 delete 作為「刪除檔案」 [4] 的方法動詞

## remove 的應用實例

* 《微軟 PowerShell 動詞表》 [2] 推薦使用 remove 表達「從容器移除物件」
  的動作
* .NET 與 Java 採用 remove 作為「從容器移除物件」 [5] 的方法動詞
* Facebook 「從好友建議名單移除某帳號」
* Linux 刪除檔案

## 互相替代性

* remove 多半可以用來取代 delete 表達「刪除」的意思
  * 例如在 Linux 上刪除檔案的 `rm` 指令

* 但 delete 多半無法取代 remove 表達「（從容器）移除物件」的意思

---
# 讀者問題： Clear vs. Clean

* clear 偏向「清場」的意思。

* clean 意指「清潔、去除污垢」的意思。

假設這樣的情景：「桌上散著書本紙張」，而我們會用「雜亂」來形容這桌子。

這時候， clear 與 clean 都可以表達「清掃整理」的意思。

再假設另一個情景：「桌上滿是湯水油污」，而我們會用「骯髒」來形容這桌子。

這時候，就適合用 clean ，而不適合用 clear 。

寫作程式時，就「清空容器」來說，例如「清空房間裡的怪物」， clear 會比
clean 更適合。

另外，有時候會用 clear 或 clean 這個字來表達「初始化記憶體區塊」這個動作
，然而，「初始化」用 initialize 表達會更適合。

---
# 讀者問題： Delete vs. Erase

* delete 的原意是「畫記、畫線槓掉想消除的文字」
  * 例如， HTML 的 `<del>` 標籤

* erase 的原意是「以擦、抹消除文字」。

在現代數位世界裡，

* 在與人溝通時， delete 與 erase 都可以表達「刪除資料、檔案」。
* 在寫程式時，多半用 delete 表達「刪除資料、物件、檔案」。
  * C++ Standard Library Vector 採用 erase 來表達「刪除容器中的物件」 [8]
    的函式動詞。
  * 可能是為了避免與 C++ 關鍵字 delete 衝突。
* 在「抹除儲存媒體資料」時（例如：磁帶），用 erase 。

---
# 讀者問題： Cancel vs. Dismiss （前端設計）

在前端設計的情景下，

## Cancel 「取消」

* 適用於「讓使用者選擇停止、放棄正要進行的動作」
* 例如：「是否要將此文章發佈出去？」
  * Cancel （取消）
  * OK （確認）

## Dismiss 「廢棄某想法 / 屏除、遣散某人」

* 適用於「讓使用者打發掉提示、提醒、警告、錯誤訊息」
* 例如：「＿＿首家線上賭場上線啦！」
  * Dismiss （朕知道了）

---
# 結語

每個人都是從零開始學起的。 :)

有任何寫程式時遇到的英文問題，歡迎推文留言。

或到《程式英文》討論區提問：

* GitHub: https://bit.ly/321ResR
* Facebook: https://bit.ly/2EsPmj9

這可以幫助我把這知識庫整理得更完善，謝謝 :)

---
# *參考* 答案

1.  clear
2.  empty
3.  delete
4.  remove

---
[1]:
https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.clear?view=netcore-3.1
[2]:
https://docs.microsoft.com/en-us/powershell/scripting/developer/cmdlet/approved-verbs-for-windows-powershell-commands?view=powershell-7
[3]:
https://docs.microsoft.com/en-us/dotnet/api/system.linq.enumerable.empty?view=netcore-3.1
[4]:
https://docs.microsoft.com/en-us/dotnet/api/system.io.file.delete?view=netcore-3.1
[5]:
https://docs.microsoft.com/en-us/dotnet/api/system.collections.objectmodel.collection-1.remove?view=netcore-3.1
[6]:
https://docs.microsoft.com/en-us/cpp/standard-library/vector-class?view=vs-2019#empty
[7]:
https://docs.microsoft.com/en-us/cpp/standard-library/vector-class?view=vs-2019#clear
[8]:
https://docs.microsoft.com/en-us/cpp/standard-library/vector-class?view=vs-2019#erase
[9]:
https://docs.microsoft.com/en-us/dotnet/api/system.string.empty?view=netcore-3.1
[10]:
https://docs.microsoft.com/en-us/dotnet/api/system.guid.empty?view=netcore-3.1

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1596190126.A.449.html
推 nyyn: 受教了 推推 07/31 19:05
推 iceman5566: truncate 表示： 07/31 19:27
推 lairx: 推 07/31 19:28
推 CaptPlanet: 推推 07/31 19:54
→ newversion: 沒有wipe嗎? 07/31 20:03
→ allenxxx: 川普:我都用fire 07/31 21:03
推 qrtt1: dispose 呢？ 07/31 21:11
→ Domos: 我個人都用annihilate 07/31 21:44
推 EntHeEnd: 推 07/31 21:46
推 mathrew: 我都用 getout 07/31 21:56
推 alihue: 我都用 kim 07/31 22:10
推 GGFACE: 我都用kill 07/31 22:17
推 naestnecniv: 那purge勒 07/31 23:59
推 FY4: 推 08/01 00:35
→ aoisama: drop table users 08/01 01:07
推 FatSquirrel: 我都用Nuke 08/01 01:38
推 Bencrie: free release destroy 08/01 02:05
推 KOD: 推推 08/01 09:49
推 mybluesky: 讚 08/01 10:12
推 Esvent: 有時候會用eliminate 08/01 10:12
推 blueskier: 還沒看 先推個 08/01 11:11

謝謝各位的欣賞 :)

推文裡提到了不少與「刪除」有關的字，來整理一下我對這些字的「感覺」：

# 與資料庫 / SQL 有關的

* drop
  * 多見於「刪除資料庫物件」的情景

* truncate
  * 也有用在其它情景，用來表達「截短」的動作
  * 相關字 trim 的動作也是「截短」，但更強調「刪除 *多餘的* 東西」

# 與資源管理有關的

* 釋放資源
  * free
  * release

* dispose 常指「（妥善）處理掉要銷毀的物件」的動作

# 語氣更強烈的「刪除」

* destroy
  * 有時候 delete 的實作方式是所謂 "soft delete", 會有 undelete 還原的選
    項；而 destroy  暗示著「不可逆的刪除」。

* purge
  * 原意是「暴力強制驅離」，可以想成「強制執行 delete 」

# 其它

* kill 常用於「終止 (OS) process (長期、持續運作的流程) 」

* wipe 與 erase 相似：
  * 表示「抹除」資料
  * 也多常用在「抹除資料儲存媒體」的情景

# 相對口語化的用詞

* annihilate
* eliminate
* nuke

其它還有

* eradicate
* terminate
* obliterate
* expunge

# 我參不透的梗 XD

* getout
* kim

# 要有霸王色霸氣才能用的 XD

* 龍老母 Daenerys Targaryen: Dracarys!

* 川普: You are fired!
※ 編輯: AmosYang (136.56.13.184 美國), 08/01/2020 14:10:11
推 alihue: kim = 金正恩 08/01 14:37

XD
※ 編輯: AmosYang (136.56.13.184 美國), 08/01/2020 14:46:55
→ Vitaceae: 儘量用前人的動詞表, 英語能力不適合在這裡發揮 08/01 15:30

同意。

愈是在公開、可見度高的

* API 介面
* 使用者介面
* 文件

我會愈傾向使用該領域人員常用的術語。

推 smart0eddie: 但是empty有些是拿來確認容器是否為空 08/01 17:11
→ smart0eddie: 像是c++ std:: vector 08/01 17:11

你說的對。

我的解讀是，那不像直接利用 empty  在英文中「清空容器內容」的動詞語意；那
比較像是 IsEmpty()  這樣「測試此容器是否為空（形容詞）」的意思。

而就「清空容器內容物」來說， C++ Standard Library 看來也是用 clear  這個
字。（我猜 clear()  的實作是會去呼叫 erase() ）

十分感謝你的提醒，我已編輯我的原文，在上面提到 empty, clear, erase  的章
節都補充了 C++ Standard Library 應用實例，謝謝 :)

推 mychiux413: 請問如果一種是丟到垃圾桶可復原的，一種是完全刪除 08/01 17:31
→ mychiux413: ，應該用什麼比較妥當？ 08/01 17:31

這要看情景、需求及此功能的使用者習慣的術語。

現代個人電腦使用者大概已經很習慣了「刪除(delete)只是 "soft delete", 刪掉
的東西還可以從回收筒救回來」這件事。所以不少使用者介面都會特別註明
"permanently delete"  字樣來強調其「不可復原性」。

就你描述的情形，或許可以這麼做：

* 提供 hide / show 功能
* 提供 delete 功能

讓使用者看到有 hide, delete 兩種功能，區分其可復原性、不可復原性。
※ 編輯: AmosYang (136.56.13.184 美國), 08/01/2020 18:47:55
推 yupog2003: 推推 08/01 18:06

謝謝 :)
※ 編輯: AmosYang (136.56.13.184 美國), 08/01/2020 19:51:07
推 ms79392002: 覺得你真的很棒 08/02 01:07
推 siuoly: 推 有學到 08/02 07:34

謝謝 :)

推 csfgsj: 所以說，寫程式，國文也要好 08/02 08:21

同意。

目的是溝通，語言是工具，文字是載體。

需要依對象、情景來思考怎麼使用語言及文字。

例如，機器、使用者、團隊成員、商業人員「想聽的東西」跟「聽得懂的東西」不
同。

而隨著情景時空改變，就算是「剛寫完程式的自己」跟「寫完程式兩週後的自己」
，「想聽的東西」跟「聽得懂的東西」也不同 XD

這的確是需要持續練習精進的題目。

推 skizard: 我都用Magic 08/02 08:32

XD

推 hanshsu: prune勒？ 08/02 09:43
→ HamalAri: virsh: destroy undefine 08/02 11:53

很有意思，整理一下我的想法：

* prune 與上面推文討論中提到的 trim 類似，意指「修剪」。

  * truncate / trim / prune 與 delete 的差別在於： delete 偏向「整個刪除
    」，而 truncate / trim / prune  偏向「消除部分」。

* destroy 上面推文討論有提到，感覺是「語氣更強烈」、「（暗示）不可逆」的
  刪除。

* undefine

  我的 *感覺* 是，這像是 set / unset  的組合。

  undefine  似乎常與 define 一起出現，而少有單獨出現的情形。
※ 編輯: AmosYang (136.56.13.184 美國), 08/02/2020 14:20:03
推 wulouise: undefime好像很少用動詞耶，用adj的倒是很多undefined 08/02 20:57

同意。

推 DCTmaybe: Dismiss 08/02 21:07

是的，另外還有 discard, 我的感覺是相對偏向前端設計會使用的字。
※ 編輯: AmosYang (136.56.13.184 美國), 08/02/2020 21:54:37
推 unmolk: 推！很受用 08/03 00:32
→ unmolk: 現在大二，學資結的時候常常看到實作的function是用remove 08/03 00:32
→ unmolk: 或clear常常覺得疑惑，現在終於比較清楚一些了 08/03 00:32

如果有其它讓你覺得困惑的單字，請讓我知道 (在這裡推文、站內信、 Facebook
簡訊、 Twitter  簡訊都可以) ，這可以幫助我把這方面的知識整理得更完善 :)

* GitHub 討論區 https://bit.ly/321ResR
* Facebook 相簿 https://bit.ly/2EsPmj9
* Twitter 討論 https://bit.ly/2D57pM5

推 ian90911: 感謝分享 08/03 10:59

不客氣 :)
※ 編輯: AmosYang (136.56.13.184 美國), 08/03/2020 16:35:58
→ APTON: 推！非常感謝 08/04 09:53

不客氣 :)

→ APTON: 沒想到當初沒深度的戰文可以引出這麼好的系列文！ 08/04 09:53

> 當初沒深度的戰文

這是指哪個討論串？ :)

我想去看看那討論串裡有沒有可以獨立出來研究的題目。
※ 編輯: AmosYang (136.56.13.184 美國), 08/04/2020 16:13:53
推 jack42107: 推 08/06 01:47

謝謝 :)

推 CoNsTaR: 我都不用刪除，我都直接 YEET!!! 掉 08/07 03:07

XD
※ 編輯: AmosYang (136.56.13.184 美國), 08/08/2020 03:10:54
推 gkkswae: 問 Dracarys適合用在那種程度的清除？ 08/08 17:36

當你需要把整個資料中心從地圖上消滅的時候？ XD
※ 編輯: AmosYang (136.56.13.184 美國), 08/12/2020 07:49:57
```
