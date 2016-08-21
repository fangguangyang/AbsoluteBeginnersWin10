```bssex
Gee Law: make github style
{
    "Embed": true,
    "Css": "github-markdown.css"
}
```

``` bssex
Gee Law: set title
null
```

# UWP 教程翻译、书写指南
###### Gee Law
本文旨在规范化、改进翻译方法，规范书写风格。

## 书写风格
### 标点、符号
总体上，所有的代码、未翻译词使用半角西文符号。在句中的标点，使用全角、简体中文用法（使用弯引号并正确配对）。一段字幕中，若有多句且中间有叹号、句号，则末尾也要有，否则不应该有末尾句号，末尾叹号、问号总是应该保留。但是，如果此段字幕的最后个分句没有结束，则不应该有末尾标点。

**错误** `这里有一个 ListView。ItemClick 事件.` 和 `进展不错！我们下次继续`

**正确** `这里有一个 ListView.ItemClick 事件` 和 `进展不错！我们下次继续。`

### 空格
除了专业排版软件如 Word，我们需要手工为半角和全角字符之间加入空格，但是全角标点和半角字符连接处无需空格。另外，产品名需要按照官方指定的格式书写。

**错误** `我们打开Visual Studio ，新建一个空白UWP项目` 和 `豆瓣 FM`

**正确** `我们打开 Visual Studio，新建一个空白 UWP 项目` 和 `豆瓣FM`

### 标准化大小写和缩写
使用正确的大小写，如果是代码，则严格按照代码大小写来；对于产品、公司、品牌名，使用官方书写方式，不要使用非产品名缩写（即使原文口语缩略了）。

**错误** `Microsoft WINDOWS`、`Win8.1`、`windows 10`、`Windows10`、`WP8.1`、`Windows Phone 10`、`IPhone` 和 `IPHONE`

**正确** `Microsoft Windows`、`Windows 8.1`、`Windows 10`、`Windows Phone 8.1`、`Windows 10 Mobile`、`iPhone` 和 `iPHONE`

### 拒绝翻译腔
后面会有例子的。

## 信达雅
### 信
忠实传达原文的含义。

| 原文 | 误 | 信 | 评注 |
| --- | --- | --- | --- |
| call GetSounds | 叫 GetSounds | 调用 GetSounds | 这里 call 应该理解为调用方法。 |
| pass in our Sounds | 通过我们的 Sounds | 传入我们的 Sounds | 这里 pass in 应该理解为传入（参数）。 |
| ObservableCollection of Sounds | Sounds 的 ObservableCollection | | |
| （同上） | Sound 的 ObservableCollection | ObservableCollection&lt;Sound&gt; | 这里注意两点：类名是单数名词，当我们说某个类的数组时，我们用 Array of 类型名（复数），对于集合类型也同理，但是对于非集合类型，例如可空 int，那是 Nullable of int（不用复数），object 的弱引用，那时 WeakReference of object（不用复数）。泛型实例化的类型 A<B> 的读法是 A of B。 |
| we are going to filter ABC | 我们将做 ABC 筛选器 | 我们将筛选 ABC | 这里 filter 是动词而不是名词。 |
| cast it to a MenuItem | 将它映射为菜单项 | 将它的类型转换为 MenuItem | 这里 cast 应该理解为类型转换而不是映射、浇筑等意思。注意在英语中，若有类 A，则 A 的单数形式 an A 表示一个 A 的实例，若有类 B 则单数形式是 a B。 |
| Let's ... | 让我们…… | 咱们（来）…… | 注意 Let's 和 Let us 是不同的，前者是第一人称复数祈使语气（提出要做事情的倡议），后者是第二人称祈使语气（“让（允许）我们”）。 |
| We use a Sound to represent a sound file. | 我们用声音表示 sound 文件。 | 我们用 Sound 表示一个声音文件。 | 你需要根据上下文理解一段口语内容（例如，同样是 sound 发音）到底是一个类名、结构名、枚举名、字段名、属性名、枚举值、方法名、变量名、事件名等等，还是一个普通的词汇。**不要总是依赖英文字幕里的大小写，一来，在句首是强制大写的，二来，英文字幕的提供者可能并未正确区分它的意思。** |
| We want to create a little Margin here... | 我们想要创建一个小小的 Margin（控件的属性）。 | 我们想要创建一个小小的边距。 | 这是一个英文字幕语义理解错误的地方。 |
| we're going to accept input from the MenuItemsListView EventHandler | ListView 将接收输入来自 MenuItemsListView EventHandler | 我们将从 MenuItemsListView 的事件处理程序接收输入 | 英文字母的大小写、concatenation 是错误的。 |
| grab the e.ClickedItem | 区分 e.ClickedItem | 取出 e.ClickedItem | grab 的意思如此。 |
| take a sound off of out desktop and drag-and-drop it in | 在桌面关闭一个音频的播放并拖入拖出 | 从桌面拖出一个音频并拖出程序并释放 | 翻译者理解错误，特别注意字幕里**一句话可能出现在不同的字幕段**！另外，drag-and-drop 的意思是拖拽——拖动并释放，不是“拖入拖出”。 |
| Play Again | 再次播放 | 重玩 | 这个出现在 UWP Album Cover Match Game 里面，这里真的比较难了，它的实际作用是在用户游戏结束（Game Over）之后重新来一局，而不是允许用户重听这张专辑的歌曲以便正确识别它是什么。 |

### 达
准确传达原文的含义。

| 原文 | 信 | 信达 | 评注 |
| --- | --- | --- | --- |
| cast the object to what it represents | 把这个对象的类型转换为它表示的。 | 把这个对象的类型转换为实际的类型。 | 意思是把类型转换为更加派生的版本。 |
| the ListView we have | 我们拥有的 ListView | 我们有的 ListView / 我们的 ListView | 这里并没有物主的意思。 |
| give us the chance to handle the event | 给予我们处理事件的机会 | 给我们处理事件的机会 | “给予”有赠送美好事物的意思，而且给予者通常比接受者有更高的地位、威望、等级等，这里应该用“给……机会”来传达“使能”的含义。（这个例子还会出现在 **雅** 里面。） |
| giving us more space here（伴随状语） | 给予我们更多空隙 | 给了我们更多空隙 | 同上。注意，这里 space 翻译成空隙是因为上下文表明，这里刚刚调过边距，因此是空隙而不是空间、空白，也可以翻译成“留白”等（需要变换语法结构）。（这个例子还会出现在 **雅** 里面。） |

### 雅
以合适的语气、语体色彩传达意思。

| 原文 | 信 或 信达 | 信达雅 | 评注 |
| --- | --- | --- | --- |
| Here again, what I want to do is grab that Event Item | 这里再一次，我要分清是哪个 Item 的 Event | 这里还是，我要**弄**清是哪个项产生的事件 | 这里英文字幕的大小写是错误的，另外“分清”和“弄清”是不同的，“分清”更多用于区分两者，或者区分原本知道的、后来因为某些原因模糊而不知道的事物，“弄清”是搞清楚一开始不知道的东西。前面的 Here again 翻译为“这里再一次”翻译腔略显浓重。 |
| give us the chance to handle the event | 给予我们处理事件的机会 | 给我们处理事件的机会 | （这个例子出现在 **达** 里面了。）“给予”和“给”有文白区别，鉴于视频是口语，我们应该用白话版本。 |
| so, once again, I'm gonna... | 那么，再一次，我将…… | 对，我要…… | 发语词其实没有具体的意思，换成中文对应的口癖。（注意，这需要根据上下文决定！） |
| giving us more space here（伴随状语） | 给了我们更多空隙 | 我们就有更多空隙了 | （这个例子出现在 **达** 里面了。）变换主宾位置，是语言更少翻译腔、更 native。 |
| until I get a little chance to get it a little bit. | 直到我有个机会发现这里多了一个逗号 | 咦，这里多了一个逗点 | 在视频中，此时演讲者发现他的代码里面多了一个逗点，因此第一个版本的翻译是信、达的，然而这个句式很翻译腔，就原文的含义、语气来说，这不是一句过于严肃的话，因此可以在翻译上更 flexible，更自然，符合汉语口语中表达该场景的情况。 |
| set VerticalAlignment to Center | 把 VerticalAlignment 设置为 Center | 把 VerticalAlignment 属性设置为 Center 枚举值 | 切合编程语境和受众，强化 VerticalAlignment、Center 都是什么。 |
| （同上） | 把 VerticalAlignment 属性设置为 Center 枚举值 | 把 VerticalAlignment 属性（竖直对齐方式）设置为 Center 枚举值（居中） | 把属性、枚举值的含义翻译出来 |
| an ItemClickEventArgs e | 一个 ItemClickEventArgs e | 一个 ItemClickEventArgs e 参数 | 切合编程语境。 |
| I think ... | （总是翻译为）我认为 | （可以翻译为）我认为、我想、我觉得 | 符合口语语境，并让表达方式多样化。 |
| create a little margin | 创建一个小小的边距 | 增加一点点边距 | 符合汉语表达习惯。而且严格地说，本来就是有边距的，只不过是 0 罢了。 |

### 膜
例如从
> 这只是一个小小的改进，但整体感觉都好了

变成
> 这这是一个微小的改进，但整体感觉都好了

## 字幕特别处理技巧
### 加入冗余：代词展开
依赖字幕的视频中，由于观看者对语言的不熟悉，他需要从字幕中了解详细内容。

首先，要注意翻译后由于语序可能发生变化，所以直接把代词替换为本地语言中对应的代词可能会导致指代不清或指代对象改变，此时必须把代词替换为它指代的那个名词。

其次，因为字幕可能会过得比较快，因此观看者可能无法完全跟上节奏，或者容易忘记两段之前的内容，如果他发现一个他不知道指代什么的代词，他需要倒带，这是很糟糕的体验，因此在必要时，应该把代词替换为指代的那个名词。除了直接替换，还可以在代词后加括号，内注指代内容。

### 加入冗余：内容重复、提前告知
例如原来三段内容：
> And we could implment this
> in a more robust way and keep track of the
> various Pages that were loaded in

可以翻译成这样三段内容（注意第一、二段的冗余）：
> 我们也可以**用另一种方式**实现它
> **这种实现方式**更可靠，它追踪
> 我们载入过的页面

其中第一段的“它”在紧邻它的上一段中有所指代（指页面导航功能）。

### 多段变一段
虽然原作者可能用了很久才把一句话憋出来，因而让字幕分成了好几段，但是它实际上是一个很短的句子。如果这句话翻译前后语序不一致，较好的做法是将这几段合并起来，写上完整的翻译的句子。

例如：
> we're going to accept input from
> the MenuItemsListView EventHandler

正确的翻译可以是：
> 我们将从 MenuItemsListView 事件处理程序接收输入

### 一段变多段
一句很长的句子可以拆成好几段。

## 编程相关：保持术语的正确性、准确性
对于初学者来说，混淆术语是很糟糕的，熟悉下面的 C# 常用术语、一般编程常用术语和对应的英文。**注意**一段英文不总是表达它的术语含义。

| 英文 | 中文 | 常见不规范术语、错误翻译 | 解释 |
| --- | --- | --- | --- |
| interface | 接口 | 界面 | 不规范版本有很浓的港台风味（似乎有一个地方就是那么翻译的）。 |
| user interface | 用户界面 | 用户接口 | 这是一个语言习惯。 |
| class | 类 | 等级、阶级、类型、类别 | |
| enumeration | 枚举 | 列举 | 这是 `enum` 关键字创建的类型。 |
| property | 属性 | 特性 | |
| attribute | 特性 | 属性 | 在 C# 中，属性是一对 getter/setter（两个可以有不存在者、不同访问修饰符等）方法，特性是施加在某些语言对象上的类实例（例如 `Flags` 特性表达 `enum` 定义的枚举是符合位集合标志表示法的，它实际上由 `FlagsAttribute` 实现）。 |
| field | 字段 | 成员变量 | “成员变量”是 C/C++ 语言的术语，对应的英文是 member variable。 |
| argument/parameter | 参数 | | 方法的参数很像是方法内的局部变量，但是它们仍然是不同的。 |
| method | 方法 | （成员）函数、成员方法 | 成员函数、函数是 C++/C 语言的术语，常见的其他语言都使用“方法”表示可能产生副作用的一段可以被调用的代码。另外，在 C# 中所有的方法都是成员，没有必要加“成员”二字。（我个人倾向于把“函数”理解为映射以及没有状态、副作用的方法。） |
| delegate | 委托 | 代理 | 这是一个标准术语。 |
| abstract method | 抽象方法 | 抽象函数、纯虚方法 | “纯虚”和“（成员）函数”都是 C++ 的用语。
| cast | 类型转换 | 浇筑、映射、变换 | 这是一个标准术语。 |
| A of B | A<B> | A 的 B、B 的 A | 这是泛型实例化得到的类/结构/接口的读法。 |
| call | 调用 | 叫、呼叫 | 根据上下文理解。 |
| pass something in | 传入某东西（作为参数） | 通过某东西 | 我很怀疑 pass in 只有和“传入”同源的含义…… |
| click event/Click event | 单击事件/Click 事件 | | 前者指和鼠标主键（对于中国人来说，通常是左键）单击等价的一系列行为触发的事件，翻译事件的语义；后者是名字为 Click 的事件，不要翻译事件的名字。当然，我们知道一般 when a click event happens, the Click event is fired. |
| event handler/EventHandler | 事件处理程序/EventHandler | （前者）事件处理器、事件处理代码、事件处理者、处理函数、处理委托 | 前者是普通词组，后者是一个委托泛型。 |
| items/Items | 项/Items | | 前者是普通词汇，后者是一个属性，见于集合容器控件。 |
| pages/Pages | 页面/Page | | 前者是普通词汇，后者 Page 类的名称的复数，表示很多个 Page 实例，鉴于汉语表达习惯，对 Page 不变复数。（这其实有待商榷，例如“贝勒”的复数是“贝子”。） |
| margin | 外边距 | 边距 | “边距”不准确。 |
| padding | 内边距 | 边距 | “边距”不准确。 |

### 关于翻译选择
对于一段英文，它可能是下列三种可能

1. 是一段普通的英文；
2. 是一个程序里面的标识符（如类名、变量名等）；
3. 是字符串资源（例如游戏的提示文本“Please get ready in {0} seconds...”）。

我提倡三种不同的翻译展示机制：

1. 只展示翻译后的内容；
2. 不翻译，并且和代码内容保持一致，但是可以用括号加注这个标识符的含义；
3. 翻译，并主要展示翻译内容，可以用括号加注原文。

举例：
> Next, we're gonna add a button that says "Play Again" and when user clicks that, we'll make it happen. For that, we need &lt;Button&gt;Play Again&lt;/Button&gt;.

可以翻译为：
> 接下来，我们要添加一个写着“再来一局”（“Play Again”）的按钮，当用户点击它的时候，我们就让他再来一局。为此，我们需要写 &lt;Button&gt;Play Again&lt;/Button&gt;。

要注意的是，可能英文字幕的格式是错误的，再比如，听译的时候只有声音，是没有大小写、标点的。这里不用为 `<Button>Play Again</Button>` 加注这是 XAML 代码，因为视频上这件事情（书写 XAML 代码）正在发生。

### 关于软件使用
请务必先把东西转换为 `.ass` 再书写，否则会导致很麻烦的问题：如果你有类似 ObservableCollection&lt;ABC&gt; 这样的文本在 `.srt` 中，它会渲染错误。

另外，避免使用大括号（{}），因为它是转义字符，如果必要，使用全角版本遮掩过去。
