## `AutoCoder.Class`
### 概要
`AutoCoder`内において、クラス定義を格納しておく要素

### 継承元
- `AutoCoder.Element`

### メンバ変数
- `public Class from`
- `public Namespace fromNamespace`
- `public ClassFunction construct`
- `public ClassFunction destruct`
- `public List<ClassFunction> funcs`
- `public <ClassVariable> vars`


### プロパティ
- `public string className`

### メンバ関数
- `public override string on_build()`
- `public override void on_Added(Element on)`
- `public string on_call()`
- `public void add_func(ClassFunction clf)`

### 派生クラス
なし