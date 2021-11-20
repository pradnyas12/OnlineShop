import { Component, OnInit } from '@angular/core';
import {Product}from 'src/Model/ProductModel';
import { MyProductService } from '../my-product.service';
@Component({
  selector: 'app-show-product',
  templateUrl: './show-product.component.html',
  styleUrls: ['./show-product.component.css']
})
export class ShowProductComponent implements OnInit {
  productdata: Array<Product>=[];
  constructor(private s:MyProductService) { }

 

  ngOnInit(): void {
    this.s.getProducts().subscribe(data => {
      this.productdata = data;
    });
  }
}

