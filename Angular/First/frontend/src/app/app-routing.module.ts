import { NgModule } from "@angular/core";
import { RouterModule, Routes } from "@angular/router";
import { PaymentCreateComponent } from "./components/payment/payment-create/payment-create.component";
import { PaymentDeleteComponent } from "./components/payment/payment-delete/payment-delete.component";
import { PaymentUpdateComponent } from "./components/payment/payment-update/payment-update.component";
//Importação dos componentes para conteúdo
import { HomeComponent } from "./views/home/home.component";
import { PaymentComponent } from "./views/payment/payment.component";

const routes: Routes = [
  {
    path: "",
    component: HomeComponent,
  },
  {
    path: "payments",
    component: PaymentComponent,
  },
  {
    path: "payments/create",
    component: PaymentCreateComponent,
  },
  {
    path: "payments/update/:id",
    component: PaymentUpdateComponent,
  },
  {
    path: "payments/delete/:id",
    component: PaymentDeleteComponent,
  },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule],
})
export class AppRoutingModule {}
