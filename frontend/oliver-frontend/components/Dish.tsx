import { createClient } from "@/utils/supabase/server";
import { cookies } from "next/headers";

interface DishProps {
    menudish: {
      dish_id: any;
      menu_id:any;
    };
  }

export default async function Dish({menudish}: DishProps) {
    const cookieStore = cookies();
    const supabase = createClient(cookieStore);

    const { data: dishData, error: dishError } = await supabase.from("dishs").select().eq("dish_id", menudish.dish_id);

    if (!dishData) {
        // Handle the case where dishData is null
        return <div>Error loading dish data</div>;
      }

    const dish = dishData[0]; // Assuming there is only one dish with the given dish_id

  // Fetch public URL for the dish image from the "dish_image_storage" bucket
  const { data: imageData} = await supabase
    .storage
    .from('dish_image_storage')
    .getPublicUrl(dish.dish_image);

    const publicURL = imageData?.publicUrl;

return(
    <div>
        {dishData?.map((dish) => (
            <div key={dish.dish_id} className="flex flex-row mt-2">
                <img src={publicURL} className="w-25"/>
                {/* <h1>{dish.dish_id}</h1>
                <h1>{dish.dish_title}</h1> */}
                <div className="pl-5 flex-col max-w-1/2">
                <h1 className="text-2xl mb-5">{dish.dish_title}</h1>
                <p>{dish.dish_description}</p>
                </div>
            </div>
        ))}
    </div>
)
}