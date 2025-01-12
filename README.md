# VRChat-Udon-Form-Filling

## <概要 Introduction 简介>
<div>
  本VRChatギミックはユーザーからの文字列と画像リンク及びゲーム内での撮影の入力(v2.0)をもらい、VRChatワールドで指定した書類ゲームオブジェクトに反映するギミックである。証明書のみならず、契約書あるいはテストペーパーなど、様々な入力が必要されている場面に使える。
最大32個の文字列入力欄と8個の画像入力欄が備えており、様々な場面にほぼ対応できる。
同期は入れておる。アップデートしたい場合はできるだけ古いバージョンを削除してください。
</div>
<div>
This VRChat gimmick receives your text and image link input, and in-game phototaking and puts them on a game object. You can use it in situations that need input like making ID cards, contracts or test papers, etc.,
There are 32 text and 8 image URL blanks at maximum, I hope it can handle most situations.
Global synced. It would be better of you delete old version when you update.
</div>
<div>
这是一个接收用户的文字与图片链接，以及游戏内拍照输入，并将他们填入游戏物体的功能。可以用在填写各种证，合同以及试卷等需要输入与填写的场合上。
最多32个文字输入栏，8个图像链接输入栏。
全局同步。更新时尽量删除老版本。
</div>

## <使い方 How to use 使用方法>
<div>
まずはPrefabをワールドに置き、Unpackする。
FormsDataのFormsManagerで自由に書類の登録の追加と削除することができる。
登録した書類のFormDataコンポーネントで、書類名前と、書類の空欄の質問と、書類のゲームオブジェクト、書類の文字と画像リンクを入れる場所を指定する。
書類の文字と画像リンクを入れる場所は、書類のゲームオブジェクトを編集することで、箇所を増減することもでき、属性も自由に編集できる。
同じ文字と写真を同時に変更したい場合はその文字あるいは写真に「Change Together With」というManualのUdonsharpBehaviorを追加し、参照の対象を設定する。その場合、FormDataでChageTogetherObjectsに追加することも必要である。（V2.0）
コピーできるようにしたい場合はObjectPoolとその中のObjectを作り、UdonBehaviourをいじり、プールをPrintButtonに登録してください。詳しいことはサンプルに参考してください。(V2.0)
六つのサンプルは既に入れておる（V2.0）。
（三つサンプルはV1.0）
</div>
<div>
Drag the prefab to the world and unpack.
You can add and delete forms' registration in FormsData's "Forms Manager" component.
You can assign the form's name, questions for blanks, game object, and places to put text and image links in the registered form's FormData component.
You can edit the form's game object to  change the numbers and properties of blanks.
If you want to change the same text and photo at the same time, add an UdonsharpBehavior in the Manual called “Change Together With” to that text or photo and set the object of reference. In that case, it is also necessary to add it to ChageTogetherObjects in FormData. (V2.0)
If you want to be able to copy, create a ObjectPool and Objects in it, tweak UdonBehaviour and register the pool at PrintButton. For more details, please refer to the sample. (V2.0)
I have already included six examples (V2.0).
(V1.0 3 samples)
</div>
<div>
将预制件拖进去unpack。
可以在FormsData的FormsManager里面登录你的表单。
在已注册表单的FormData里面可以指定表单名, 表单的空栏的问题，表单物体，表单的文字和图片链接的地方。
可以在表单物体里编辑增减放文字和图片链接的地方。
如果想同时更改同一文本和照片，请在手册中为该文本或照片添加名为 “Change Together With”的 UdonsharpBehaviour，并设置引用对象。 在这种情况下，还需要将其添加到 FormData 中的 ChageTogetherObjects 中。 (V2.0)
如果希望复印，请创建一个ObjectPool和其中的对象，调整 UdonBehaviour 并在 PrintButton 注册该池。 有关详细信息，请参阅示例。 (V2.0)
已经放了六个例子(V2.0)。
(V1.0只有3个例子)
</div>
<div>
悪用しないでください。
</div>
<div>
Please don't use it for any bad purpose!
</div>
<div>
请勿将此用在不好的地方。
</div>

## <後書き Note 后记>
<div>
ただ他のワールドを作る傍らで作ったもので、ガチで作ったギミックではない。
質問などは日本語と英語と中国語が対応できる。
</div>
<div>
I just made it when I'm  making  other worlds. I didn't spend too much effort. 
I can answer questions in Japanese, English, and Chinese.
</div>
<div>
这只是做别的地图时顺手做了一个，没有投入太多精力。
如有疑问，中日英三语皆可。
</div>

## <更新履歴 Release 更新历史>
2025/01/13 v2.0
-写真欄の撮影機能を追加した 
-手書きエリアと関連機能を追加した
-作成した書類をコピーする機能を追加した
‐結婚証明書、奴隷契約書、VRC虹色運転免許証を新しいサンプルとして追加した
-Added Photographing
-Added Handwritting area and related functions
-Added Copy Function
-Added Marriage Certification, Master Slave Contract, and VRC Rainbow Japanese Driving License as new samples
-添加了拍照功能
-添加了手写区及相关功能
-添加了复印功能
-添加了结婚证，主仆契约，VRC彩虹驾照作为新的例子
<div>
2024/12/21 v1.0
</div>

## <ライセンス　License 使用协议>
<div>
MIT License
</div>
<div>
Copyright (c) 2024 HX2 xianglong90
</div>
