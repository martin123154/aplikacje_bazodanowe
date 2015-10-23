<?php

namespace common\models;

use Yii;
use yii\base\Model;
use yii\data\ActiveDataProvider;
use common\models\Zakup;

/**
 * ZakupSearch represents the model behind the search form about `common\models\Zakup`.
 */
class ZakupSearch extends Zakup
{
		public $klient_imie;
	public $klient_nazwisko;
    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'klient_id'], 'integer'],
            [['data_zakupu'], 'safe'],
			
			[['klient_imie'], 'safe'],
			  [['klient_nazwisko'], 'safe'],
        ];
    }

    /**
     * @inheritdoc
     */
    public function scenarios()
    {
        // bypass scenarios() implementation in the parent class
        return Model::scenarios();
    }

    /**
     * Creates data provider instance with search query applied
     *
     * @param array $params
     *
     * @return ActiveDataProvider
     */
    public function search($params)
    {
        $query = Zakup::find()
		->innerJoin('{{%klient}}', '{{%klient}}.id = klient_id');

        $dataProvider = new ActiveDataProvider([
            'query' => $query,
        ]);

        $this->load($params);

        if (!$this->validate()) {
            // uncomment the following line if you do not want to any records when validation fails
            // $query->where('0=1');
            return $dataProvider;
        }

        $query->andFilterWhere([
            'id' => $this->id,
            'data_zakupu' => $this->data_zakupu,
            'klient_id' => $this->klient_id,
        ]);
		
		$query->andFilterWhere(['like', '{{%klient}}.nazwisko', $this->klient_nazwisko]);
		$query->andFilterWhere(['like', '{{%klient}}.imie', $this->klient_imie]);

        return $dataProvider;
    }
}
