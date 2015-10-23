<?php

namespace common\models;

use Yii;
use yii\base\Model;
use yii\data\ActiveDataProvider;
use common\models\Wystep;

/**
 * WystepSearch represents the model behind the search form about `common\models\Wystep`.
 */
class WystepSearch extends Wystep
{
 /**
     * @todo Dodajemy zmienną gatunek_nazwa
     */
    public $spektakl_tytul;
	public $aktor_imie;
	public $aktor_nazwisko;
	
    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['id', 'aktor_id', 'spektakl_id'], 'integer'],
			 /**
             * @todo Umożliwiamy wprowadzanie danych do zmiennej gatunek_nazwa (wymagane dla zmiennych typu string)
             */
            [['spektakl_tytul'], 'safe'],
			 [['aktor_imie'], 'safe'],
			  [['aktor_nazwisko'], 'safe'],
			
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
    {  /**
         * @todo Złaczamy tabelę gatunek
         */
        $query = Wystep::find()
		->innerJoin('{{%spektakl}}', '{{%spektakl}}.id = spektakl_id')
		->innerJoin('{{%aktor}}', '{{%aktor}}.id = aktor_id')
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
            'aktor_id' => $this->aktor_id,
            'spektakl_id' => $this->spektakl_id,
        ]);
		
		 /**
         * @todo Dodajemy filtr dla nowej zmiennej
         */
        $query->andFilterWhere(['like', '{{%spektakl}}.tytul', $this->spektakl_tytul]);
		$query->andFilterWhere(['like', '{{%aktor}}.imie', $this->aktor_imie]);
		$query->andFilterWhere(['like', '{{%aktor}}.nazwisko', $this->aktor_nazwisko]);
	

        return $dataProvider;
    }
}
