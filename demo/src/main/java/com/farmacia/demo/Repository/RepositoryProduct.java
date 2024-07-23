package com.farmacia.demo.Repository;

import com.farmacia.demo.Models.Product;
import com.farmacia.demo.Models.User;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface RepositoryProduct extends JpaRepository<Product,String> {

    //List<Product> findByNameStorageAndSoftDelete(String name, boolean softDelete);
    List<Product> findBySoftDeleteIsFalse();
}
