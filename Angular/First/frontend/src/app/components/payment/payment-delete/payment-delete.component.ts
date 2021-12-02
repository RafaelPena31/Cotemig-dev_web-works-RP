import { Component, OnInit } from "@angular/core";
import { ActivatedRoute, Router } from "@angular/router";
import { Payment } from "../payment.model";
import { PaymentService } from "../payment.service";

@Component({
  selector: "app-payment-delete",
  templateUrl: "./payment-delete.component.html",
  styleUrls: ["./payment-delete.component.css"],
})
export class PaymentDeleteComponent implements OnInit {
  payment: Payment;

  constructor(
    private paymentService: PaymentService,
    private router: Router,
    private route: ActivatedRoute
  ) {
    this.payment = { nome: "", valor: 0, categoria: "", codigo: 0 };
  }

  ngOnInit(): void {
    let id = this.route.snapshot.paramMap.get("id") || 0;
    id = +id;

    this.paymentService.readById(id).subscribe((payment) => {
      this.payment = payment;
    });
  }

  deletePayment(): void {
    this.paymentService.delete(this.payment.id || 0).subscribe(() => {
      this.paymentService.showMessage("Deletado com sucesso");
      this.router.navigate(["/payments"]);
    });
  }

  cancel(): void {
    this.router.navigate(["/payments"]);
  }
}
