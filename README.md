毎回ランダムな地面を生成して、HPが0にならないように最下層まで辿り着く単純なゲームです。
初期HPは「100」であり、1段を超えて降りてしまうと、その1段ごとに「30」点のダメージを受けます。
また、ジャンプをした状態で1段以上降りた場合、追加で「15」点のダメージを受けます。1段をジャンプして降りた場合、この「15」点だけを受けることになります。
1段ごとにジャンプを交えて降りるとHPが足らないように作っているので、生成運が悪いとどこかで思い切った判断が必要になります。
逆に、最初から思い切った判断をして、どの地面にもぶつからないように自由落下をするという遊び方も想定されています。

シーン切り替えでステージ制にする案と迷いましたが、単純なゲームは固定のステージ構成よりもランダム生成の方が面白くなるものだと考え、ステージの床はランダムに生成されるように設定しました。

このゲームはUnityで作成され、スクリプトはVisual studio 2022で作成しました。動作確認についてもUnity上で行っています。
実際にかけた時間を計測はしていません(100時間もかかっていないとは思います)が、6月下旬よりちょうど1ヶ月程度の作成期間で完成しました。
