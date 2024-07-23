package com.farmacia.demo.Models;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

import java.util.Date;
import java.util.UUID;

@Setter
@Getter
@ToString

@Entity
@Table(name = "user")
public class User {
    @Id
    private String id;
    private String name;
    private String lastName;
    private String email;
    private String password;
    private Date creatAT;
    private boolean softDelete;

    public User(){
    }

    public void generateId(){
        id = String.valueOf(UUID.randomUUID());
    }
    public boolean getSoftDelete(){
        return softDelete;
    }
    public void setSoftDelete(boolean softDelete) {
        this.softDelete = softDelete;
    }

}
