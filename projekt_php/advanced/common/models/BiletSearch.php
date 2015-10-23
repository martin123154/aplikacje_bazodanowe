<?php

namespace common\models;

use Yii;
use yii\base\Model;
use yii\data\ActiveDataProvider;
use common\models\Bilet;

/**
 * BiletSearch represents the model behind the search form about `common\models\Bilet`.
 */
class BiletSearch extends Bilet
{
	 /**
     * @todo Dodajemy zmienną 
     */
    public $spektakl_tytul;
	 public $zakup_data_zakupu;
	 public $spektakl_data_rozp;
	
	
    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'rzad', 'miejsce', 'spektakl_id', 'zakup_id'], 'integer'],
            [['cena'], 'number'],
            [['rodzaj'], 'safe'],
			 [['spektakl_tytul'], 'safe'],
			 [['zakup_data_zakupu'], 'safe'],
			 [['spektakl_data_rozp'], 'safe'],
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
        $query = Bilet::find()
		->innerJoin('{{%spektakl}}', '{{%spektakl}}.id = spektakl_id')
		->innerJoin('{{%zakup}}', '{{%zakup}}.id = zakup_id')
		
		
		;

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
            'cena' => $this->cena,
            'rzad' => $this->rzad,
            'miejsce' => $this->miejsce,
            'spektakl_id' => $this->spektakl_id,
            'zakup_id' => $this->zakup_id,
        ]);

        $query->andFilterWhere(['like', 'rodzaj', $this->rodzaj]);
		  $query->andFilterWhere(['like', '{{%spektakl}}.tytul', $this->spektakl_tytul]);
		  $query->andFilterWhere(['like', '{{%zakup}}.data_zakupu', $this->zakup_data_zakupu]);
		   $query->andFilterWhere(['like', '{{%spektakl}}.data_rozp', $this->spektakl_data_rozp]);

        return $dataProvider;
    }
}
