import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Product } from "./service/product.model";
import { ProductService } from "./service/product.service";

@Component({
  selector: "app-product-create",
  templateUrl: "./product-create.component.html",
  styleUrls: ["./product-create.component.css"],
})
export class ProductCreateComponent implements OnInit {
  product: Product = {
    nome: "",
    descricao: "",
    idadeRecomendada: "",
    valor: "",
  };

  constructor(private productService: ProductService, private router: Router) {}

  ngOnInit(): void {}

  createProduct(): void {
    const { nome, descricao, idadeRecomendada, valor } = this.product;
    if (nome && descricao && idadeRecomendada && valor) {
      this.productService.create(this.product).subscribe(() => {
        this.productService.showMessage("Produto cadastrado!");
        this.router.navigate(["/product"]);
      });
    } else {
      this.productService.showMessage(
        "Preencha corretamente todos os campos",
        true
      );
    }
  }

  cancel(): void {
    this.router.navigate(["/product"]);
  }
}
