/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package projekt;

import java.beans.PropertyChangeListener;
import java.beans.PropertyChangeSupport;
import java.io.Serializable;
import java.math.BigDecimal;
import javax.persistence.Basic;
import javax.persistence.Column;
import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.NamedQueries;
import javax.persistence.NamedQuery;
import javax.persistence.Table;
import javax.persistence.Transient;
import javax.persistence.GeneratedValue;
import javax.persistence.GenerationType;

/**
 *
 * @author Jola
 */
@Entity
@Table(name = "bilet", catalog = "mzelek", schema = "dbo")
@NamedQueries({
    @NamedQuery(name = "Bilet_1.findAll", query = "SELECT b FROM Bilet_1 b"),
    @NamedQuery(name = "Bilet_1.findByBiletId", query = "SELECT b FROM Bilet_1 b WHERE b.biletId = :biletId"),
    @NamedQuery(name = "Bilet_1.findByBiletCena", query = "SELECT b FROM Bilet_1 b WHERE b.biletCena = :biletCena"),
    @NamedQuery(name = "Bilet_1.findByBiletRodzaj", query = "SELECT b FROM Bilet_1 b WHERE b.biletRodzaj = :biletRodzaj"),
    @NamedQuery(name = "Bilet_1.findByBiletRzad", query = "SELECT b FROM Bilet_1 b WHERE b.biletRzad = :biletRzad"),
    @NamedQuery(name = "Bilet_1.findByBiletMiejsce", query = "SELECT b FROM Bilet_1 b WHERE b.biletMiejsce = :biletMiejsce"),
    @NamedQuery(name = "Bilet_1.findByBiletPremieraId", query = "SELECT b FROM Bilet_1 b WHERE b.biletPremieraId = :biletPremieraId"),
    @NamedQuery(name = "Bilet_1.findByBiletZakupId", query = "SELECT b FROM Bilet_1 b WHERE b.biletZakupId = :biletZakupId")})
public class Bilet_1 implements Serializable {
    @Transient
    private PropertyChangeSupport changeSupport = new PropertyChangeSupport(this);
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy=GenerationType.IDENTITY) 
    @Basic(optional = false)
    @Column(name = "bilet_id")
    private Integer biletId;
    // @Max(value=?)  @Min(value=?)//if you know range of your decimal fields consider using these annotations to enforce field validation
    @Column(name = "bilet_cena")
    private BigDecimal biletCena;
    @Column(name = "bilet_rodzaj")
    private String biletRodzaj;
    @Column(name = "bilet_rzad")
    private Integer biletRzad;
    @Column(name = "bilet_miejsce")
    private Integer biletMiejsce;
    @Basic(optional = false)
    @Column(name = "bilet_premiera_id")
    private int biletPremieraId;
    @Basic(optional = false)
    @Column(name = "bilet_zakup_id")
    private int biletZakupId;

    public Bilet_1() {
    }

    public Bilet_1(Integer biletId) {
        this.biletId = biletId;
    }

    public Bilet_1(Integer biletId, int biletPremieraId, int biletZakupId) {
        this.biletId = biletId;
        this.biletPremieraId = biletPremieraId;
        this.biletZakupId = biletZakupId;
    }

    public Integer getBiletId() {
        return biletId;
    }

    public void setBiletId(Integer biletId) {
        Integer oldBiletId = this.biletId;
        this.biletId = biletId;
        changeSupport.firePropertyChange("biletId", oldBiletId, biletId);
    }

    public BigDecimal getBiletCena() {
        return biletCena;
    }

    public void setBiletCena(BigDecimal biletCena) {
        BigDecimal oldBiletCena = this.biletCena;
        this.biletCena = biletCena;
        changeSupport.firePropertyChange("biletCena", oldBiletCena, biletCena);
    }

    public String getBiletRodzaj() {
        return biletRodzaj;
    }

    public void setBiletRodzaj(String biletRodzaj) {
        String oldBiletRodzaj = this.biletRodzaj;
        this.biletRodzaj = biletRodzaj;
        changeSupport.firePropertyChange("biletRodzaj", oldBiletRodzaj, biletRodzaj);
    }

    public Integer getBiletRzad() {
        return biletRzad;
    }

    public void setBiletRzad(Integer biletRzad) {
        Integer oldBiletRzad = this.biletRzad;
        this.biletRzad = biletRzad;
        changeSupport.firePropertyChange("biletRzad", oldBiletRzad, biletRzad);
    }

    public Integer getBiletMiejsce() {
        return biletMiejsce;
    }

    public void setBiletMiejsce(Integer biletMiejsce) {
        Integer oldBiletMiejsce = this.biletMiejsce;
        this.biletMiejsce = biletMiejsce;
        changeSupport.firePropertyChange("biletMiejsce", oldBiletMiejsce, biletMiejsce);
    }

    public int getBiletPremieraId() {
        return biletPremieraId;
    }

    public void setBiletPremieraId(int biletPremieraId) {
        int oldBiletPremieraId = this.biletPremieraId;
        this.biletPremieraId = biletPremieraId;
        changeSupport.firePropertyChange("biletPremieraId", oldBiletPremieraId, biletPremieraId);
    }

    public int getBiletZakupId() {
        return biletZakupId;
    }

    public void setBiletZakupId(int biletZakupId) {
        int oldBiletZakupId = this.biletZakupId;
        this.biletZakupId = biletZakupId;
        changeSupport.firePropertyChange("biletZakupId", oldBiletZakupId, biletZakupId);
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (biletId != null ? biletId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Bilet_1)) {
            return false;
        }
        Bilet_1 other = (Bilet_1) object;
        if ((this.biletId == null && other.biletId != null) || (this.biletId != null && !this.biletId.equals(other.biletId))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "projekt.Bilet_1[ biletId=" + biletId + " ]";
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.removePropertyChangeListener(listener);
    }
    
}
