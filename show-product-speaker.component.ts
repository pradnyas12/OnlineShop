import { Component, OnInit } from '@angular/core';
import {Product}from 'src/Model/ProductModel';
import { MyProductService } from '../my-product.service';
@Component({
  selector: 'app-show-product-speaker',
  templateUrl: './show-product-speaker.component.html',
  styleUrls: ['./show-product-speaker.component.css']
})
export class ShowProductSpeakerComponent implements OnInit {
  productdata: Array<Product>=[];
  constructor(private s:MyProductService) { }

  ngOnInit(): void { this.s.getProducts().subscribe(data => {
    this.productdata = data;
  });
  }

}
