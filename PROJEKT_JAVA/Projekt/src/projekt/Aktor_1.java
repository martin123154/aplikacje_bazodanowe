/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package projekt;

import java.beans.PropertyChangeListener;
import java.beans.PropertyChangeSupport;
import java.io.Serializable;
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
@Table(name = "aktor", catalog = "mzelek", schema = "dbo")
@NamedQueries({
    @NamedQuery(name = "Aktor_1.findAll", query = "SELECT a FROM Aktor_1 a"),
    @NamedQuery(name = "Aktor_1.findByAktorId", query = "SELECT a FROM Aktor_1 a WHERE a.aktorId = :aktorId"),
    @NamedQuery(name = "Aktor_1.findByAktorImie", query = "SELECT a FROM Aktor_1 a WHERE a.aktorImie = :aktorImie"),
    @NamedQuery(name = "Aktor_1.findByAktorNazwisko", query = "SELECT a FROM Aktor_1 a WHERE a.aktorNazwisko = :aktorNazwisko"),
    @NamedQuery(name = "Aktor_1.findByAktorPesel", query = "SELECT a FROM Aktor_1 a WHERE a.aktorPesel = :aktorPesel")})
public class Aktor_1 implements Serializable {
    @Transient
    private PropertyChangeSupport changeSupport = new PropertyChangeSupport(this);
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy=GenerationType.IDENTITY) 
    @Basic(optional = false)
    @Column(name = "aktor_id")
    private Integer aktorId;
    @Basic(optional = false)
    @Column(name = "aktor_imie")
    private String aktorImie;
    @Basic(optional = false)
    @Column(name = "aktor_nazwisko")
    private String aktorNazwisko;
    @Basic(optional = false)
    @Column(name = "aktor_pesel")
    private String aktorPesel;

    public Aktor_1() {
    }

    public Aktor_1(Integer aktorId) {
        this.aktorId = aktorId;
    }

    public Aktor_1(Integer aktorId, String aktorImie, String aktorNazwisko, String aktorPesel) {
        this.aktorId = aktorId;
        this.aktorImie = aktorImie;
        this.aktorNazwisko = aktorNazwisko;
        this.aktorPesel = aktorPesel;
    }

    public Integer getAktorId() {
        return aktorId;
    }

    public void setAktorId(Integer aktorId) {
        Integer oldAktorId = this.aktorId;
        this.aktorId = aktorId;
        changeSupport.firePropertyChange("aktorId", oldAktorId, aktorId);
    }

    public String getAktorImie() {
        return aktorImie;
    }

    public void setAktorImie(String aktorImie) {
        String oldAktorImie = this.aktorImie;
        this.aktorImie = aktorImie;
        changeSupport.firePropertyChange("aktorImie", oldAktorImie, aktorImie);
    }

    public String getAktorNazwisko() {
        return aktorNazwisko;
    }

    public void setAktorNazwisko(String aktorNazwisko) {
        String oldAktorNazwisko = this.aktorNazwisko;
        this.aktorNazwisko = aktorNazwisko;
        changeSupport.firePropertyChange("aktorNazwisko", oldAktorNazwisko, aktorNazwisko);
    }

    public String getAktorPesel() {
        return aktorPesel;
    }

    public void setAktorPesel(String aktorPesel) {
        String oldAktorPesel = this.aktorPesel;
        this.aktorPesel = aktorPesel;
        changeSupport.firePropertyChange("aktorPesel", oldAktorPesel, aktorPesel);
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (aktorId != null ? aktorId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Aktor_1)) {
            return false;
        }
        Aktor_1 other = (Aktor_1) object;
        if ((this.aktorId == null && other.aktorId != null) || (this.aktorId != null && !this.aktorId.equals(other.aktorId))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "projekt.Aktor_1[ aktorId=" + aktorId + " ]";
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.removePropertyChangeListener(listener);
    }
    
}
