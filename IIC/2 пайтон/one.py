# 1
import pandas as pd
import matplotlib.pyplot as plt

# Зчитайте дані з файлу
data = pd.read_csv('vgsales.csv')

# # 1
# # # Відфільтрація ігор на платформі PC
# pc_games = data[data['Platform'] == 'PC']
# top_10_pc_games = pc_games.sort_values(by='Global_Sales', ascending=False).head(10)
# print(top_10_pc_games[['Name', 'Global_Sales']])


# 2
# # Відфільтрація гри Super Mario Bros. та її продажі в Європі
# super_mario_sales_eu = data[(data['Name'] == 'Super Mario Bros.') & (data['EU_Sales'] > 0)]
# plt.figure(figsize=(12, 6))
# plt.plot(super_mario_sales_eu['Year'], super_mario_sales_eu['EU_Sales'], marker='o', linestyle='-')
# plt.title('Продажі гри Super Mario Bros. в Європі за роками')
# plt.xlabel('Рік')
# plt.ylabel('Продажі в Європі (млн копій)')
# plt.grid(True)
# plt.show()



# # 3
# Відфільтрація даних за 2020 рік та для Північної Америки
na_sales_2020 = data[(data['Year'] == 2020) & (data['NA_Sales'] > 0)]
most_sold_genre = na_sales_2020['Genre'].value_counts().idxmax()
total_sales_of_genre = na_sales_2020[na_sales_2020['Genre'] == most_sold_genre]['NA_Sales'].sum()
print(f"Найчастіше продавалися ігри жанру {most_sold_genre}, і загальна кількість проданих ігор цього жанру у 2020 році: {total_sales_of_genre} млн копій")


# 4
# # Відфільтрація даних за останні 10 років
# recent_data = data[data['Year'] >= 2013]
# top_publishers = recent_data['Publisher'].value_counts().head(5)
# plt.figure(figsize=(8, 8))
# plt.pie(top_publishers, labels=top_publishers.index, autopct='%1.1f%%', startangle=140)
# plt.title('Доля проданих ігор 5 найпопулярніших видавництв (за останні 10 роки)')
# plt.show()


# # 5
# #  Стовпеці для категоризації років у групи по 5 років
# data['Year_Group'] = (data['Year'] // 5) * 5
# avg_global_sales = data.groupby('Year_Group')['Global_Sales'].mean()
# plt.figure(figsize=(12, 6))
# plt.bar(avg_global_sales.index, avg_global_sales.values, width=4)
# plt.title('Середня кількість проданих ігор у світі за кожні 5 років')
# plt.xlabel('Роки (починаючи з 1980)')
# plt.ylabel('Середня кількість проданих ігор (млн копій)')
# plt.grid(axis='y', linestyle='--', alpha=0.7)
# plt.show()

