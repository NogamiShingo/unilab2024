# ユニラブ2024
ユニラブ2024の仕様説明などを書いていきます。

## 各ファイルの役割
unilab2024は複数の`.cs`ファイルで構成されています。以下でそれぞれの役割について説明します。

機能が追加され次第追記していきます。
<details>

<summary>Program.cs</summary>

### Program.cs

`Program.cs`はこのプログラムの核となるファイルです。複数のclassが用意されています。

#### internal static class Program
関数`Main()`が存在します。これはプログラムを実行したときに最初に実行される関数です。
データの読み込みを行い，以下のコードで`Title`フォームを呼び出します。
```csharp
Application.Run(new Title());
```

#### public partial class Func
このプログラムで使用する関数は原則ここに書き留めることにしました。関数の役割ごとに`#region`環境でまとめます。以下はその例です。
極力この例に従い、何がどこにあるかわかるようにしています。
```csharp
#region フォーム呼び出し
public static void CreateForm1(Form currentForm)
{
  //関数の定義
}

public static void CreateForm2(Form currentForm)
{
  //関数の定義
}
#endregion
```

なお、別のフォームから`Func`クラス内の関数を呼び出す際は次のように関数名の前に`Func.`を付けます。
```csharp
Func.CreateForm1(this);
```
</details>

<details>

<summary>Title.cs</summary>

### Title.cs

このプログラムを実行して最初に立ち上がるフォームです。このフォームを閉じるとプログラムが終了してしまうので注意します。

「はじめる」ボタンが設置されており、これを押すと`Prologue.cs`が起動します。

以降はゲームの進行状況を大まかに記憶しておき，誤ってフォームをCloseしてしまっても「はじめる」ボタンを押せば同じ場所に戻ってくる仕様になっています．

</details>

<details>

<summary>Prologue.cs</summary>

### Prologue.cs

`Title.cs`の次に呼び出されるフォームです。ストーリーのプロローグを表示します。

キャラ選択機能が実装してあり，ボタンを押すと以降で使用するキャラを選べる仕様にしてあります．

キャラ選択が終わったら1-1を起動する仕様になっています．

</details>

<details>

<summary>WorldMap.cs</summary>

### WorldMap.cs

ワールド（学年）選択を行うフォームです。ボタンが複数配置されています。
各ボタンを押したときに`StageSelect.cs`のメンバ変数`WorldName`を指定して同フォームを立ち上げます。

クリア状況に応じて押せるボタンと押せないボタンを分けています．また，卒業試験クリア前までは`AnotherWorld.cs`に遷移するボタンは表示しないようにしています．

</details>

<details>

<summary>StageSelect.cs</summary>

### StageSelect.cs

`WorldMap.cs`で何らかのワールド選択をする，または`Stage.cs`から戻ったときに立ち上がるフォームです。選択されたワールドによって表示内容を変えるため、classとしての**メンバ変数**を定義しています。
これは別フォームからの変更が効くようになっています。例えば次のような感じです.
```csharp
public class StageSelect : Form
{
        #region 各種メンバ変数の定義
        private string _worldName;  //WorldMapで選択された学年
        
        public string WorldName     //こう書くと別フォームからアクセスできるっぽい。原理はよくわからん
        {
            get { return _worldName; }
            set { _worldName = value; }
            //別フォームからのアクセス例
            //StageSelect form = new StageSelect();
            //form.WorldName = "学年";
        }
        #endregion
}
```

このフォームからは`Stage.cs`、または`WorldMap.cs`に遷移することができます。
1-3クリアまでは`WorldMap.cs`に遷移するボタンを非表示にしています．

</details>

<details>

<summary>Stage.cs</summary>

### Stage.cs

`StageSelect.cs`でステージを選択することで立ち上がるフォームです。選択したステージごとに描画を変更するため、classとしての**メンバ変数**を定義しています。
またボタンなどのコントロール毎に動作を定義しています。例えば次のような感じです。
```csharp
public static void ResetListBox(ListBox listbox)   //ListBoxの中身消去
{
        if (listbox.SelectedIndex > -1)
        {
                listbox.Items.RemoveAt(listbox.SelectedIndex);
        }
        else
        {
                listbox.Items.Clear();
        }
}
```
またキャラクターの動作をボタン入力によって実装し、ユーザからの入力を変換することでMap上で動きとして表現してあります。
衝突検知は`colision_detection`という関数で実装してあります。
また会話機能が実装してあり、画面に入力のヒントや操作方法などが表示されます。
</details>
