```
作者 AmosYang (泛用人型編碼器)
看板 Soft_Job
標題 [心得][命名] 縮寫、簡寫的優缺點
時間 Fri Nov 27 15:46:09 2020
```

# 縮寫、簡寫的優缺點

* Google Docs 版： https://bit.ly/2JgaQCL
* GitHub 討論區： https://bit.ly/321ResR

---

在「刷 LeetCode 練習命名」（ https://bit.ly/2GIyLtk ）時，我觀察到
LeetCode 提供的程式碼樣板經常使用簡寫與縮寫；例如，以下案例中，用 `nums`
代表 `numbers`; 用 `J` 代表寶石（ jewel ）；用 `S` 代表石頭（ stone ）。

```C#
// https://leetcode.com/problems/running-sum-of-1d-array/
public int[] RunningSum(int[] nums)
```

```C#
// https://leetcode.com/problems/jewels-and-stones/
public int NumJewelsInStones(string J, string S)
```

在這系列文章的討論中，也有網友提過「用 `qty`, `cnt` 代表 quantity, count 」
的主張。

這讓我很好奇，有沒有什麼方法可以更全面、一致地評量「縮寫、簡寫的優缺點」？

我試著從以下角度切入：
「每個生態圈、社群、團隊、專案多半會有約定成俗的命名風格」；例如，

* 遊戲業人士可能會用 `hp` 代表耐久力（ hit points ）。
* 工業界人士可能會用 `hp` 代表馬力（ horse power ）。

這個「約定成俗」的過程可說是「『知覺負載』成本效益取捨」的演化過程。

## 知覺負載

所謂「知覺負載（ cognitive load ）」是指「某件事的『難度』」，也就是
「該件事有多耗腦力（工作記憶資源）」；它從三個層面來分析「難度」：

* 一件事本質（ intrinsic ）上有多難。
  * 例如，「算 2+2 」與「算微分方程式」的難度不同。
* 外部（ extraneous ）因素對一件事的難度的影響
  * 例如，同樣的知識，對母語是中文的我們來說，「用中文吸收」與
    「用英文吸收」的難度不同。
* 個人將一件事（的原理）真正搞懂（內化）有多難。
  * 例如，「知道」與「做到」的難度不同。

參考資料： https://en.wikipedia.org/wiki/Cognitive_load

## `num`, `qty`, `cnt`

從知覺負載的角度來看，「理解 `num`, `qty`, `cnt` 這些符號」本質上並不難，
但問題是不同生態圈、社群、團隊、專案的人經歷過的「約定成俗／「知覺負載成
本效益取捨」演化過程」也不同，就像是遊戲業人士、工業界人士對 `hp` 最直覺
（知覺負載成本最低）的聯想也不同。

是故，與其論述「縮寫、簡寫的優缺點」，我更傾向去思考「縮寫、簡寫會如何影
響誰的知覺負載成本效益」。

易言之，與其論述「在程式碼中使用縮寫、簡寫」是簡潔（ brevity ）還是
隱晦（ obscurity ），我會去想「這份程式碼是為了什麼而要給誰看？這些人有
什麼樣的共同記憶？」，來決定要用什麼樣的語言來溝通。

---

感謝參與 https://github.com/EngTW/English-for-Programmers/issues/7 討論
的網友。

```
--
※ 發信站: 批踢踢實業坊(ptt.cc), 來自: 136.56.13.184 (美國)
※ 文章網址: https://www.ptt.cc/bbs/Soft_Job/M.1606463173.A.5E7.html
```
