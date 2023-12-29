import { Component, OnInit } from '@angular/core';
import { Apollo, gql } from 'apollo-angular';
import { Observable, map, of } from 'rxjs';

const GET_PRODUCTS = gql`
  {
    products {
      name
    }
  }
`;

@Component({
  selector: 'app-product',
  templateUrl: './product.component.html',
  styleUrls: ['./product.component.scss']
})
export class ProductComponent implements OnInit {
  public products: Observable<any[]>;

  constructor(private appollo: Apollo) { }

  ngOnInit() {
    this.products = of([{
      name: "some"
    }]);

    this.products = this.appollo
      .watchQuery({
        query: GET_PRODUCTS
      })
      .valueChanges.pipe(map(((result: any) => result.data && result.data.products)));
  }
}
