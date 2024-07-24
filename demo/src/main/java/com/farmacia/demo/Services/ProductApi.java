package com.farmacia.demo.Services;

import com.farmacia.demo.Models.Product;
import com.farmacia.demo.Repository.RepositoryProduct;
import org.springframework.beans.factory.annotation.Autowired;
import org.springframework.http.HttpStatus;
import org.springframework.http.ResponseEntity;
import org.springframework.web.bind.annotation.*;

import javax.swing.text.html.parser.Entity;
import java.util.*;

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

    //falta modificar y eliminar

    @PutMapping("/EditarProducto")
    public ResponseEntity<String> editarProducto(@RequestBody HashMap<String,Object> mapa){

        String id= (String) mapa.get("id");//con esto se puede convcertir el id en un Stireng para poder buscarlo

        Product p = null;

        Optional<Product> optionalProduct = repositoryProduct.findById(id);
        if(optionalProduct.isPresent()){
            p= optionalProduct.get();
        }else{
            return new ResponseEntity<>("No se encontro el producto que se desea modificar", HttpStatus.NOT_FOUND);
        }
        //borrar la referencia del id
        mapa.remove("id");
        //en el mapa tenemos todas las entradas que se sedesn modificar de la clase que selecionaron


        for (Map.Entry<String, Object> entry : mapa.entrySet()){
            String key = entry.getKey();

            switch ( key ){

                case "title":
                    p.setTitle((String) entry.getValue());
                    break;
                case "description":
                    p.setDescription((String) entry.getValue());
                    break;
                case "imagen":
                    p.setImagen((String) entry.getValue());
                    break;

                case "softDelete":
                    p.setSoftDelete((Boolean) entry.getValue());
                    break;

            }
        }
        repositoryProduct.save(p);

            return new ResponseEntity<>("Se modifico el producto de manera exitosa ", HttpStatus.OK);
    }
    //Metodo de eliminacion
    @DeleteMapping("/DeleteProduct")
    public ResponseEntity<String> deleteProduct(@RequestParam String id ){

        Product p = null;

        Optional<Product> optionalProduct = repositoryProduct.findById(id);
        if(optionalProduct.isPresent()){
            p= optionalProduct.get();
            repositoryProduct.deleteById(p.getId());
            return new ResponseEntity<>("Se elimino el producto de manera exitosa", HttpStatus.OK);
        }else{

            return new ResponseEntity<>("no se encontro el prioducto que se deseaba enviar", HttpStatus.NOT_FOUND);
        }
    }
}
