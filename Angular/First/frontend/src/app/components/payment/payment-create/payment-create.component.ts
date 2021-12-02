import { Component, OnInit } from "@angular/core";
import { Router } from "@angular/router";
import { Payment } from "../payment.model";
import { PaymentService } from "../payment.service";

@Component({
  selector: "app-payment-create",
  templateUrl: "./payment-create.component.html",
  styleUrls: ["./payment-create.component.css"],
})
export class PaymentCreateComponent implements OnInit {
  payment: Payment = {
    nome: "",
    valor: 0,
    categoria: "",
    codigo: 0,
  };

  constructor(private paymentService: PaymentService, private router: Router) {}

  ngOnInit(): void {}

  createPayment(): void {
    this.paymentService.create(this.payment).subscribe(() => {
      this.paymentService.showMessage("Cartão cadastrado!");
      this.router.navigate(["/payments"]);
    });
  }

  cancel(): void {
    this.router.navigate(["/payments"]);
  }
}
