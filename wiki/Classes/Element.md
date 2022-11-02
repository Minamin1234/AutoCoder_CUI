## `AutoCoder.Element`
### 概要
`AutoCoder`内において、処理の実装/定義を記述する際の全ての要素。

### メンバ変数
- `public uint level`
    - インデントのレベル
- `public string name`
    - 要素の名称
- `public Language language`
    - 記述する際の言語
- `public string content`
    - ビルド済みの内容

### プロパティ
- `public string Begin`
    - 要素から文字に書き起こす際のインデント
- `public string NewLine`
    - 要素から文字に書き起こす際の改行

### メンバ関数
- `public Element()`
    - コンストラクタ
- `public virtual string on_build()`
    - 要素がビルドされる際に呼ばれます。
- `public virtual void on_Added(Element on)`
    - 要素が別の要素のリスト等に追加された際に呼ばれます。

### 派生クラス
- `AutoCoder.Namespace`
- `AutoCoder.Class`
- `AutoCoder.Function`
    - `AutoCoder.ClassFunction`
- `AutoCoder.Arg`
- `AutoCoder.Variable`
    - `AutoCoder.ClassVariable`
- `AutoCoder.Struct`
- `AutoCoder.Type`
- `AutoCoder.Enum`