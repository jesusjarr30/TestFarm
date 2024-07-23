package com.farmacia.demo.Services;

import com.farmacia.demo.Models.Product;
import com.farmacia.demo.Models.User;
import com.farmacia.demo.Repository.RepositoryUser;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
@CrossOrigin("http://localhost:4200/")
@RequestMapping("/User")
@RestController
public class UserApi {
    @Autowired
    private RepositoryUser repositoryUser;

    @PostMapping("/addUser")
    public ResponseEntity<String> addUser(@RequestBody User user){
        user.generateId();
        repositoryUser.save(user);//save the class
        return new ResponseEntity<>("Producto register success ", HttpStatus.OK);
    }
    @GetMapping("/getuser")
    public List<User> getUser(){
        return repositoryUser.findBySoftDeleteIsFalse();
    }
}
