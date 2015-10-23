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
@Table(name = "premiera", catalog = "mzelek", schema = "dbo")
@NamedQueries({
    @NamedQuery(name = "Premiera_1.findAll", query = "SELECT p FROM Premiera_1 p"),
    @NamedQuery(name = "Premiera_1.findByPremieraId", query = "SELECT p FROM Premiera_1 p WHERE p.premieraId = :premieraId"),
    @NamedQuery(name = "Premiera_1.findByPremieraTytul", query = "SELECT p FROM Premiera_1 p WHERE p.premieraTytul = :premieraTytul"),
    @NamedQuery(name = "Premiera_1.findByPremieraDataRozp", query = "SELECT p FROM Premiera_1 p WHERE p.premieraDataRozp = :premieraDataRozp"),
    @NamedQuery(name = "Premiera_1.findByPremieraDataZak", query = "SELECT p FROM Premiera_1 p WHERE p.premieraDataZak = :premieraDataZak")})
public class Premiera_1 implements Serializable {
    @Transient
    private PropertyChangeSupport changeSupport = new PropertyChangeSupport(this);
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy=GenerationType.IDENTITY) 
    @Basic(optional = false)
    @Column(name = "premiera_id")
    private Integer premieraId;
    @Column(name = "premiera_tytul")
    private String premieraTytul;
    @Column(name = "premiera_data_rozp")
    private String premieraDataRozp;
    @Column(name = "premiera_data_zak")
    private String premieraDataZak;

    public Premiera_1() {
    }

    public Premiera_1(Integer premieraId) {
        this.premieraId = premieraId;
    }

    public Integer getPremieraId() {
        return premieraId;
    }

    public void setPremieraId(Integer premieraId) {
        Integer oldPremieraId = this.premieraId;
        this.premieraId = premieraId;
        changeSupport.firePropertyChange("premieraId", oldPremieraId, premieraId);
    }

    public String getPremieraTytul() {
        return premieraTytul;
    }

    public void setPremieraTytul(String premieraTytul) {
        String oldPremieraTytul = this.premieraTytul;
        this.premieraTytul = premieraTytul;
        changeSupport.firePropertyChange("premieraTytul", oldPremieraTytul, premieraTytul);
    }

    public String getPremieraDataRozp() {
        return premieraDataRozp;
    }

    public void setPremieraDataRozp(String premieraDataRozp) {
        String oldPremieraDataRozp = this.premieraDataRozp;
        this.premieraDataRozp = premieraDataRozp;
        changeSupport.firePropertyChange("premieraDataRozp", oldPremieraDataRozp, premieraDataRozp);
    }

    public String getPremieraDataZak() {
        return premieraDataZak;
    }

    public void setPremieraDataZak(String premieraDataZak) {
        String oldPremieraDataZak = this.premieraDataZak;
        this.premieraDataZak = premieraDataZak;
        changeSupport.firePropertyChange("premieraDataZak", oldPremieraDataZak, premieraDataZak);
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (premieraId != null ? premieraId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Premiera_1)) {
            return false;
        }
        Premiera_1 other = (Premiera_1) object;
        if ((this.premieraId == null && other.premieraId != null) || (this.premieraId != null && !this.premieraId.equals(other.premieraId))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "projekt.Premiera_1[ premieraId=" + premieraId + " ]";
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.removePropertyChangeListener(listener);
    }
    
}
