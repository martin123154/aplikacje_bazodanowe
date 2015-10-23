<?php

namespace common\models;

use Yii;

/**
 * This is the model class for table "klient".
 *
 * @property integer $id
 * @property string $imie
 * @property string $nazwisko
 * @property string $pesel
 *
 * @property Zakup[] $zakups
 */
class Klient extends \yii\db\ActiveRecord
{
    /**
     * @inheritdoc
     */
    public static function tableName()
    {
        return 'klient';
    }

    /**
     * @inheritdoc
     */
    public function rules()
    {
        return [
            [['imie', 'nazwisko'], 'required'],
            [['imie', 'nazwisko'], 'string','min' => 2, 'max' => 255],
            [['pesel'], 'string', 'min' => 11, 'max' => 11],
			[['pesel'], 'unique'],
        ];
    }

    /**
     * @inheritdoc
     */
    public function attributeLabels()
    {
        return [
            'id' => Yii::t('app', 'ID'),
            'imie' => Yii::t('app', 'Imie'),
            'nazwisko' => Yii::t('app', 'Nazwisko'),
            'pesel' => Yii::t('app', 'Pesel'),
        ];
    }

    /**
     * @return \yii\db\ActiveQuery
     */
    public function getZakups()
    {
        return $this->hasMany(Zakup::className(), ['klient_id' => 'id']);
    }
	public function getNazwisko(){
    return $this->imie . ' ' . $this->nazwisko . ' ' . $this->pesel;
	}
	public function getNazwisk(){
    return $this->imie . ' ' . $this->nazwisko;
}
}
