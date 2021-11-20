import { Component, OnInit } from '@angular/core';
import {Product}from 'src/Model/ProductModel';
import { MyProductService } from '../my-product.service';

@Component({
  selector: 'app-payment-page',
  templateUrl: './payment-page.component.html',
  styleUrls: ['./payment-page.component.css']
})
export class PaymentPageComponent implements OnInit {

  productdata: Array<Product>=[];
  constructor(private s:MyProductService) { }

  ngOnInit(): void {this.s.getProducts().subscribe(data => {
    this.productdata = data;
  });
  }

}
