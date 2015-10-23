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
@Table(name = "klient", catalog = "mzelek", schema = "dbo")
@NamedQueries({
    @NamedQuery(name = "Klient_1.findAll", query = "SELECT k FROM Klient_1 k"),
    @NamedQuery(name = "Klient_1.findByKlientId", query = "SELECT k FROM Klient_1 k WHERE k.klientId = :klientId"),
    @NamedQuery(name = "Klient_1.findByKlientImie", query = "SELECT k FROM Klient_1 k WHERE k.klientImie = :klientImie"),
    @NamedQuery(name = "Klient_1.findByKlientNazwisko", query = "SELECT k FROM Klient_1 k WHERE k.klientNazwisko = :klientNazwisko"),
    @NamedQuery(name = "Klient_1.findByKlientPesel", query = "SELECT k FROM Klient_1 k WHERE k.klientPesel = :klientPesel")})
public class Klient_1 implements Serializable {
    @Transient
    private PropertyChangeSupport changeSupport = new PropertyChangeSupport(this);
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy=GenerationType.IDENTITY) 
    @Basic(optional = false)
    @Column(name = "klient_id")
    private Integer klientId;
    @Basic(optional = false)
    @Column(name = "klient_imie")
    private String klientImie;
    @Basic(optional = false)
    @Column(name = "klient_nazwisko")
    private String klientNazwisko;
    @Basic(optional = false)
    @Column(name = "klient_pesel")
    private String klientPesel;

    public Klient_1() {
    }

    public Klient_1(Integer klientId) {
        this.klientId = klientId;
    }

    public Klient_1(Integer klientId, String klientImie, String klientNazwisko, String klientPesel) {
        this.klientId = klientId;
        this.klientImie = klientImie;
        this.klientNazwisko = klientNazwisko;
        this.klientPesel = klientPesel;
    }

    public Integer getKlientId() {
        return klientId;
    }

    public void setKlientId(Integer klientId) {
        Integer oldKlientId = this.klientId;
        this.klientId = klientId;
        changeSupport.firePropertyChange("klientId", oldKlientId, klientId);
    }

    public String getKlientImie() {
        return klientImie;
    }

    public void setKlientImie(String klientImie) {
        String oldKlientImie = this.klientImie;
        this.klientImie = klientImie;
        changeSupport.firePropertyChange("klientImie", oldKlientImie, klientImie);
    }

    public String getKlientNazwisko() {
        return klientNazwisko;
    }

    public void setKlientNazwisko(String klientNazwisko) {
        String oldKlientNazwisko = this.klientNazwisko;
        this.klientNazwisko = klientNazwisko;
        changeSupport.firePropertyChange("klientNazwisko", oldKlientNazwisko, klientNazwisko);
    }

    public String getKlientPesel() {
        return klientPesel;
    }

    public void setKlientPesel(String klientPesel) {
        String oldKlientPesel = this.klientPesel;
        this.klientPesel = klientPesel;
        changeSupport.firePropertyChange("klientPesel", oldKlientPesel, klientPesel);
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (klientId != null ? klientId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Klient_1)) {
            return false;
        }
        Klient_1 other = (Klient_1) object;
        if ((this.klientId == null && other.klientId != null) || (this.klientId != null && !this.klientId.equals(other.klientId))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "projekt.Klient_1[ klientId=" + klientId + " ]";
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.removePropertyChangeListener(listener);
    }
    
}
