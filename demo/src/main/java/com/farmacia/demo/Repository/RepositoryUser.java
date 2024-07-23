package com.farmacia.demo.Repository;

import com.farmacia.demo.Models.User;
import org.springframework.data.jpa.repository.JpaRepository;
import org.springframework.stereotype.Repository;

import java.util.List;

@Repository
public interface RepositoryUser extends JpaRepository<User,String> {

    //List<User> findByNameStorageAndSoftDelete(String name, boolean softDelete);
    List<User> findBySoftDeleteIsFalse();
}
