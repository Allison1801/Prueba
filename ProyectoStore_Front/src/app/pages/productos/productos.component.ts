import { Component, OnInit } from '@angular/core';
import { ServiciosService } from '../services/servicios.service';
import { Producto } from '../interfaces/producto.interface';

@Component({
  selector: 'app-productos',
  templateUrl: './productos.component.html',
  styleUrls: ['./productos.component.css']
})
export class ProductosComponent implements OnInit {

  productos: Producto[] = []; 
  constructor( private productService : ServiciosService){}

  ngOnInit(): void {
    this.productService.getProductos().subscribe(productos => {
      this.productos = productos;
    });
  }
}
