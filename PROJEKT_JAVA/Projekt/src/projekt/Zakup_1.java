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
@Table(name = "zakup", catalog = "mzelek", schema = "dbo")
@NamedQueries({
    @NamedQuery(name = "Zakup_1.findAll", query = "SELECT z FROM Zakup_1 z"),
    @NamedQuery(name = "Zakup_1.findByZakupId", query = "SELECT z FROM Zakup_1 z WHERE z.zakupId = :zakupId"),
    @NamedQuery(name = "Zakup_1.findByZakupDataZakupu", query = "SELECT z FROM Zakup_1 z WHERE z.zakupDataZakupu = :zakupDataZakupu"),
    @NamedQuery(name = "Zakup_1.findByZakupKlientId", query = "SELECT z FROM Zakup_1 z WHERE z.zakupKlientId = :zakupKlientId")})
public class Zakup_1 implements Serializable {
    @Transient
    private PropertyChangeSupport changeSupport = new PropertyChangeSupport(this);
    private static final long serialVersionUID = 1L;
    @Id
@GeneratedValue(strategy=GenerationType.IDENTITY) 
    @Basic(optional = false)
    @Column(name = "zakup_id")
    private Integer zakupId;
    @Column(name = "zakup_data_zakupu")
    private String zakupDataZakupu;
    @Basic(optional = false)
    @Column(name = "zakup_klient_id")
    private int zakupKlientId;

    public Zakup_1() {
    }

    public Zakup_1(Integer zakupId) {
        this.zakupId = zakupId;
    }

    public Zakup_1(Integer zakupId, int zakupKlientId) {
        this.zakupId = zakupId;
        this.zakupKlientId = zakupKlientId;
    }

    public Integer getZakupId() {
        return zakupId;
    }

    public void setZakupId(Integer zakupId) {
        Integer oldZakupId = this.zakupId;
        this.zakupId = zakupId;
        changeSupport.firePropertyChange("zakupId", oldZakupId, zakupId);
    }

    public String getZakupDataZakupu() {
        return zakupDataZakupu;
    }

    public void setZakupDataZakupu(String zakupDataZakupu) {
        String oldZakupDataZakupu = this.zakupDataZakupu;
        this.zakupDataZakupu = zakupDataZakupu;
        changeSupport.firePropertyChange("zakupDataZakupu", oldZakupDataZakupu, zakupDataZakupu);
    }

    public int getZakupKlientId() {
        return zakupKlientId;
    }

    public void setZakupKlientId(int zakupKlientId) {
        int oldZakupKlientId = this.zakupKlientId;
        this.zakupKlientId = zakupKlientId;
        changeSupport.firePropertyChange("zakupKlientId", oldZakupKlientId, zakupKlientId);
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (zakupId != null ? zakupId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Zakup_1)) {
            return false;
        }
        Zakup_1 other = (Zakup_1) object;
        if ((this.zakupId == null && other.zakupId != null) || (this.zakupId != null && !this.zakupId.equals(other.zakupId))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "projekt.Zakup_1[ zakupId=" + zakupId + " ]";
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.removePropertyChangeListener(listener);
    }
    
}
