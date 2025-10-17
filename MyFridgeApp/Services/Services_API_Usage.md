# Fridge Management App – Service Layer API Usage

This document explains how to use the **Service classes** (`ItemService`, `CategoryService`, `CartService`, `HistoryService`) in the WinForms app.  
Each method is asynchronous (`async/await`) and backed by EF Core.

---

## 📦 ItemService

### Get all items
```csharp
var items = await ItemService.GetAllAsync();
dataGridView1.DataSource = items;  // Bind to DataGridView
```

### Search items
```csharp
var results = await ItemService.SearchAsync(
    name: txtSearch.Text,
    categoryId: selectedCategoryId,
    expireTo: DateTime.Today.AddDays(7)
);
```

### Get expiring soon
```csharp
var expiring = await ItemService.GetExpiringSoonAsync(5); // next 5 days
```

### Create item
```csharp
await ItemService.CreateAsync(new Item {
    Name = "Milk",
    CategoryId = 5, // Dairy
    ImportDate = DateTime.Today,
    ExpiryDate = DateTime.Today.AddDays(7),
    Quantity = 2,
    Unit = "bottles"
});
```

### Update item
```csharp
item.Quantity = 10;
await ItemService.UpdateAsync(item);
```

### Change quantity
```csharp
await ItemService.ChangeQuantityAsync(itemId, -1); // consume 1 unit
```

### Soft delete item
```csharp
await ItemService.SoftDeleteAsync(itemId);
```

### Restore deleted item
```csharp
await ItemService.RestoreAsync(itemId);
```

### Permanently clear deleted items
```csharp
await ItemService.PurgeDeletedAsync();
```

---

## 🗂 CategoryService

### Get all categories
```csharp
var categories = await CategoryService.GetAllAsync();
comboBoxCategory.DataSource = categories;
comboBoxCategory.DisplayMember = "Name";
comboBoxCategory.ValueMember = "Id";
```

### Find category by name
```csharp
int? catId = await CategoryService.GetIdByNameAsync("Bakery");
```

---

## 🛒 CartService

### Get or create open cart
```csharp
var cart = await CartService.GetOrCreateOpenCartAsync();
cartGrid.DataSource = cart.Items;
```

### Add from inventory
```csharp
await CartService.AddFromInventoryAsync(itemId, 3);
```

### Add custom item
```csharp
await CartService.AddCustomAsync("Soy Sauce", categoryId: 8, quantity: 1, unit: "bottle");
```

### Remove item from cart
```csharp
await CartService.RemoveItemAsync(cartItemId);
```

### Clear current cart
```csharp
await CartService.ClearOpenCartAsync();
```

### Place order
```csharp
await CartService.PlaceOrderAsync();
```

### Get past carts (history)
```csharp
var history = await CartService.GetHistoryAsync();
cartHistoryGrid.DataSource = history;
```

---

## 📜 HistoryService

### Get deleted items
```csharp
var deletedItems = await HistoryService.GetDeletedItemsAsync();
historyGrid.DataSource = deletedItems;
```

### Restore a deleted item
```csharp
await HistoryService.RestoreItemAsync(itemId);
```

### Clear all deleted items permanently
```csharp
await HistoryService.PurgeAllDeletedItemsAsync();
```

### Get cart history
```csharp
var carts = await HistoryService.GetCartHistoryAsync();
cartHistoryGrid.DataSource = carts;
```

### Delete one cart from history
```csharp
await HistoryService.DeleteCartFromHistoryAsync(cartId);
```

---

##  Summary

- **ItemService** → Inventory CRUD + soft delete + search.  
- **CategoryService** → Fixed categories, read-only.  
- **CartService** → Shopping cart (open, add, place order, clear, history).  
- **HistoryService** → Manage deleted items and past carts.  

All APIs are **async** – always use `await` inside WinForms `async void` event handlers.
