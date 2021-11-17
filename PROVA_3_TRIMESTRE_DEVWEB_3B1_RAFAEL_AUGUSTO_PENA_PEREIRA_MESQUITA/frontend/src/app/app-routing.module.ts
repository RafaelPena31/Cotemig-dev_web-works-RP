import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
//Importação dos componentes para conteúdo
import { HomeComponent } from "./views/home/home.component";
import { ProductCreateComponent } from "./views/product-create/product-create.component";
import { ProductComponent } from "./views/product/product.component";

const routes: Routes = [
  {
    path: "",
    component: HomeComponent,
  },
  {
    path: "product",
    component: ProductComponent,
  },
  {
    path: "product/create",
    component: ProductCreateComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
