## `AutoCoder.Element`
### �T�v
`AutoCoder`���ɂ����āA�����̎���/��`���L�q����ۂ̑S�Ă̗v�f�B

### �����o�ϐ�
- `public uint level`
    - �C���f���g�̃��x��
- `public string name`
    - �v�f�̖���
- `public Language language`
    - �L�q����ۂ̌���
- `public string content`
    - �r���h�ς݂̓��e

### �v���p�e�B
- `public string Begin`
    - �v�f���當���ɏ����N�����ۂ̃C���f���g
- `public string NewLine`
    - �v�f���當���ɏ����N�����ۂ̉��s

### �����o�֐�
- `public Element()`
    - �R���X�g���N�^
- `public virtual string on_build()`
    - �v�f���r���h�����ۂɌĂ΂�܂��B
- `public virtual void on_Added(Element on)`
    - �v�f���ʂ̗v�f�̃��X�g���ɒǉ����ꂽ�ۂɌĂ΂�܂��B

### �h���N���X
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