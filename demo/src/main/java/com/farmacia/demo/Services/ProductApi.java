package com.farmacia.demo.Services;

import com.farmacia.demo.Models.Product;
import com.farmacia.demo.Repository.RepositoryProduct;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import java.util.List;
@CrossOrigin("http://localhost:4200/")
@RequestMapping("/Product")
@RestController
public class ProductApi {
    @Autowired
    private RepositoryProduct repositoryProduct;

    @PostMapping("/addProduct")
    public ResponseEntity<String> addLender(@RequestBody Product product){
        product.generateId();
        repositoryProduct.save(product);//save the class
        return new ResponseEntity<>("Producto register success ", HttpStatus.OK);
    }
    @GetMapping("/getProduct")

    public List<Product> getMass(){
        return repositoryProduct.findBySoftDeleteIsFalse();
    }


}
