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
@Table(name = "wystep", catalog = "mzelek", schema = "dbo")
@NamedQueries({
    @NamedQuery(name = "Wystep_1.findAll", query = "SELECT w FROM Wystep_1 w"),
    @NamedQuery(name = "Wystep_1.findByWystepId", query = "SELECT w FROM Wystep_1 w WHERE w.wystepId = :wystepId"),
    @NamedQuery(name = "Wystep_1.findByWystepPremieraId", query = "SELECT w FROM Wystep_1 w WHERE w.wystepPremieraId = :wystepPremieraId"),
    @NamedQuery(name = "Wystep_1.findByWystepAktorId", query = "SELECT w FROM Wystep_1 w WHERE w.wystepAktorId = :wystepAktorId")})
public class Wystep_1 implements Serializable {
    @Transient
    private PropertyChangeSupport changeSupport = new PropertyChangeSupport(this);
    private static final long serialVersionUID = 1L;
    @Id
    @GeneratedValue(strategy=GenerationType.IDENTITY) 
    @Basic(optional = false)
    @Column(name = "wystep_id")
    private Integer wystepId;
    @Basic(optional = false)
    @Column(name = "wystep_premiera_id")
    private int wystepPremieraId;
    @Basic(optional = false)
    @Column(name = "wystep_aktor_id")
    private int wystepAktorId;

    public Wystep_1() {
    }

    public Wystep_1(Integer wystepId) {
        this.wystepId = wystepId;
    }

    public Wystep_1(Integer wystepId, int wystepPremieraId, int wystepAktorId) {
        this.wystepId = wystepId;
        this.wystepPremieraId = wystepPremieraId;
        this.wystepAktorId = wystepAktorId;
    }

    public Integer getWystepId() {
        return wystepId;
    }

    public void setWystepId(Integer wystepId) {
        Integer oldWystepId = this.wystepId;
        this.wystepId = wystepId;
        changeSupport.firePropertyChange("wystepId", oldWystepId, wystepId);
    }

    public int getWystepPremieraId() {
        return wystepPremieraId;
    }

    public void setWystepPremieraId(int wystepPremieraId) {
        int oldWystepPremieraId = this.wystepPremieraId;
        this.wystepPremieraId = wystepPremieraId;
        changeSupport.firePropertyChange("wystepPremieraId", oldWystepPremieraId, wystepPremieraId);
    }

    public int getWystepAktorId() {
        return wystepAktorId;
    }

    public void setWystepAktorId(int wystepAktorId) {
        int oldWystepAktorId = this.wystepAktorId;
        this.wystepAktorId = wystepAktorId;
        changeSupport.firePropertyChange("wystepAktorId", oldWystepAktorId, wystepAktorId);
    }

    @Override
    public int hashCode() {
        int hash = 0;
        hash += (wystepId != null ? wystepId.hashCode() : 0);
        return hash;
    }

    @Override
    public boolean equals(Object object) {
        // TODO: Warning - this method won't work in the case the id fields are not set
        if (!(object instanceof Wystep_1)) {
            return false;
        }
        Wystep_1 other = (Wystep_1) object;
        if ((this.wystepId == null && other.wystepId != null) || (this.wystepId != null && !this.wystepId.equals(other.wystepId))) {
            return false;
        }
        return true;
    }

    @Override
    public String toString() {
        return "projekt.Wystep_1[ wystepId=" + wystepId + " ]";
    }

    public void addPropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.addPropertyChangeListener(listener);
    }

    public void removePropertyChangeListener(PropertyChangeListener listener) {
        changeSupport.removePropertyChangeListener(listener);
    }
    
}
