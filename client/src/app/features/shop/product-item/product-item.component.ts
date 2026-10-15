import { Component, Input } from '@angular/core';
import { Product } from '../../../shared/models/product';
import { MatCardActions, MatCardContent, MatCardModule } from '@angular/material/card';
import { MatButton, MatButtonModule } from '@angular/material/button';
import { CurrencyPipe } from '@angular/common';
import { MatIcon } from '@angular/material/icon';

@Component({
  selector: 'app-product-item',
  imports: [
    MatCardModule, 
    MatIcon,
    MatButton, 
    MatCardActions, 
    MatCardContent, 
    CurrencyPipe
  ],
  templateUrl: './product-item.component.html',
  styleUrl: './product-item.component.css'
})
export class ProductItemComponent {
  @Input() product?: Product;
}
