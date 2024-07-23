package com.farmacia.demo.Models;


import lombok.Getter;
import lombok.Setter;
import lombok.ToString;

import javax.persistence.Entity;
import javax.persistence.Id;
import javax.persistence.Table;
import java.util.Date;
import java.util.UUID;

@Setter
@Getter
@ToString

@Entity
@Table(name = "product")

public class Product {
    @Id
    private String id;
    private String title;
    private String description;
    private String imagen;
    private Date creatAt;
    private boolean softDelete;

    public Product(){
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

